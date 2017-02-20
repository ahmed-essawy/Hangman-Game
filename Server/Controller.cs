﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Server
{
    public partial class Controller : Form
    {
        private Dictionary<int, Clients> clients;
        private static Dictionary<int, string> ClientsData;
        private Thread thread1, thread2, thread3;
        private Dictionary<int, string> players;
        private Dictionary<int, Room> rooms;
        private List<string> cats;
        private int rooms_count = 0;
        private SqlConnection con;
        private SqlCommand com;

        public Controller()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            clients = new Dictionary<int, Clients>();
            ClientsData = new Dictionary<int, string>();
            players = new Dictionary<int, string>();
            rooms = new Dictionary<int, Room>();
            cats = new List<string>();
            con = new SqlConnection("Data Source =.; Initial Catalog = Hangman-Game; Integrated Security = True");
            com = new SqlCommand();
            com.Connection = con;
            foreach (string Cat in Get_Categories())
            {
                List_Categories.Items.Add(Cat);
            }
            for (int i = 1; i <= 3; i++)
            {
                comboBox_level.Items.Add(i);
            }
            comboBox_level.SelectedIndex = 0;
            // Bring data from database
            Room r1 = new Room(1, "Room 1", "Sports", 1, "Test");
            Room r2 = new Room(3, "Room 2", "Movies", 2, "Test");
            r2.AddPlayer(50);
            Room r3 = new Room(5, "Room 3", "Sports", 3, "Test");
            rooms.Add(rooms_count++, r1);
            rooms.Add(rooms_count++, r2);
            rooms.Add(rooms_count++, r3);
        }

        private void ClientCreator()
        {
            TcpListener listener = new TcpListener(new IPAddress(new byte[] { 127, 0, 0, 1 }), 5000);
            listener.Start();
            while (true)
            {
                Socket socket = listener.AcceptSocket();
                if (socket.Connected)
                {
                    Clients temp_client = new Clients(socket);
                    clients.Add(temp_client.Endpoint, temp_client);
                    List_Connected_endpoint.Items.Add(temp_client.Endpoint);
                    List_Connected_name.Items.Add(temp_client.Name);
                    foreach (string item in Get_Categories())
                    {
                        temp_client.bWriter = "Category;" + item;
                        for (int i = 0; i < 05000; i++) ;
                    }
                    foreach (int index in rooms.Keys.ToList())
                    {
                        temp_client.bWriter = "Room;" + index + ";" + rooms[index].Name + ";" + rooms[index].Category + ";" + rooms[index].Level + ";" + rooms[index].Check_Count();
                        for (int i = 0; i < 05000; i++) ;
                    }
                    //players.Add(temp_client.Endpoint, temp_client.Name);
                }
            }
        }

        private void DataReader()
        {
            while (true)
            {
                try
                {
                    foreach (int port in ClientsData.Keys.ToList())
                    {
                        string[] response = ClientsData[port].Split(';');
                        string type = response[0];
                        switch (type)
                        {
                            case "Message":
                                MessageBox.Show(response[1]);
                                break;

                            case "New Room":
                                int creator = int.Parse(response[1]);
                                string newroomname = response[2];
                                string newroomcat = response[3];
                                int newroomlvl = int.Parse(response[4]);
                                string newroomword = Get_Word(newroomcat, newroomlvl);
                                clients[creator].bWriter = "Room Word;" + newroomword + ";;" + rooms_count;
                                Room temp_room = new Room(creator, newroomname, newroomcat, newroomlvl, newroomword);
                                rooms.Add(rooms_count, temp_room);
                                type += " (" + newroomcat + ", lvl" + newroomlvl + ")";
                                foreach (int index in clients.Keys.ToList())
                                {
                                    clients[index].bWriter = "Room;" + rooms_count + ";" + temp_room.Name + ";" + temp_room.Category + ";" + temp_room.Level + ";" + temp_room.Check_Count();
                                }
                                rooms_count++;
                                break;

                            case "Join Room Confirm":
                                int joinroomconfirm = int.Parse(response[1]);
                                int player2confirm = int.Parse(response[2]);
                                int ownerconfirm = rooms[joinroomconfirm].Owner;
                                clients[ownerconfirm].bWriter = "New Player;" + joinroomconfirm + ";" + player2confirm + ";" + clients[player2confirm].Name + ";" + rooms[joinroomconfirm].Word;
                                break;

                            case "Join Room Reply":
                                int joinroom = int.Parse(response[1]);
                                int player2 = int.Parse(response[2]);
                                rooms[joinroom].AddPlayer(player2);
                                clients[player2].bWriter = "Join Room Accepted;" + rooms[joinroom].Word + ";" + rooms[joinroom].Pressed + ";" + joinroom;
                                clients[rooms[joinroom].Player1].bWriter = "Play Form Enable;true;Player 1: " + clients[rooms[joinroom].Player1].Name + ";0";
                                foreach (int index in clients.Keys.ToList())
                                {
                                    clients[index].bWriter = "Change Room Capacity;" + joinroom;
                                }
                                type += " (" + clients[player2].Name + " joined room to play)";
                                break;

                            case "Button Pressed":
                                int roomsendpress = int.Parse(response[1]);
                                string playersendpress = response[2];
                                string charpressed = response[3];
                                if (playersendpress.Contains("Player 1"))
                                {
                                    clients[rooms[roomsendpress].Player2].bWriter = "Dim Button;" + charpressed;
                                }
                                else if (playersendpress.Contains("Player 2"))
                                {
                                    clients[rooms[roomsendpress].Player1].bWriter = "Dim Button;" + charpressed;
                                }
                                foreach (int index in rooms[roomsendpress].Watchers)
                                {
                                    for (int i = 0; i < 05000; i++) ;
                                    clients[index].bWriter = "Dim Button;" + charpressed;
                                }
                                rooms[roomsendpress].AddPress(charpressed);
                                type += " (" + playersendpress + " press " + response[3] + ")";
                                break;

                            case "Change Control":
                                int roomsendchange = int.Parse(response[1]);
                                string playersendchange = response[2];
                                int count = int.Parse(response[3]);
                                if (playersendchange.Contains("Player 1"))
                                {
                                    rooms[roomsendchange].Current = "Player 2: " + clients[rooms[roomsendchange].Player2].Name;
                                    clients[rooms[roomsendchange].Player1].bWriter = "Play Form Enable;false;Player 2: " + clients[rooms[roomsendchange].Player2].Name + ";" + count;
                                    for (int i = 0; i < 05000; i++) ;
                                    clients[rooms[roomsendchange].Player2].bWriter = "Play Form Enable;true;Your Turn;" + count;
                                    foreach (int index in rooms[roomsendchange].Watchers)
                                    {
                                        for (int i = 0; i < 05000; i++) ;
                                        clients[index].bWriter = "Play Form Enable;false;Player 2: " + clients[rooms[roomsendchange].Player2].Name + ";" + count;
                                    }
                                }
                                else if (playersendchange.Contains("Player 2"))
                                {
                                    rooms[roomsendchange].Current = "Player 1: " + clients[rooms[roomsendchange].Player1].Name;
                                    clients[rooms[roomsendchange].Player1].bWriter = "Play Form Enable;true;Your Turn; " + count;
                                    for (int i = 0; i < 05000; i++) ;
                                    clients[rooms[roomsendchange].Player2].bWriter = "Play Form Enable;false;Player 1: " + clients[rooms[roomsendchange].Player1].Name + ";" + count;
                                    foreach (int index in rooms[roomsendchange].Watchers)
                                    {
                                        for (int i = 0; i < 05000; i++) ;
                                        clients[index].bWriter = "Play Form Enable;false;Player 1: " + clients[rooms[roomsendchange].Player1].Name + ";" + count;
                                    }
                                }
                                break;

                            case "Watch Room":
                                int watcherid = int.Parse(response[1]);
                                int watchroomid = int.Parse(response[2]);
                                rooms[watchroomid].AddWatcher(watcherid);
                                clients[watcherid].bWriter = "Watch Room Info;" + rooms[watchroomid].Word + ";" + rooms[watchroomid].Pressed + ";" + rooms[watchroomid].Current;
                                type += " (" + clients[watcherid].Name + " watch game)";
                                break;

                            case "Win Game":
                                int winroomid = int.Parse(response[1]);
                                string winplayer = response[2];
                                if (winplayer.Contains("Player 1"))
                                {
                                    rooms[winroomid].Winner_Count = 1;
                                    rooms[winroomid].AddWinner(1);
                                    clients[rooms[winroomid].Player2].bWriter = "Play Form Enable;false;Winner: Player 1: " + clients[rooms[winroomid].Player1].Name + ";0";
                                    foreach (int index in rooms[winroomid].Watchers)
                                    {
                                        clients[index].bWriter = "Play Form Enable;false;Winner: Player 1: " + clients[rooms[winroomid].Player1].Name + ";0";
                                    }
                                }
                                else if (winplayer.Contains("Player 2"))
                                {
                                    rooms[winroomid].Winner_Count = 2;
                                    rooms[winroomid].AddWinner(2);
                                    clients[rooms[winroomid].Player1].bWriter = "Play Form Enable;false;Winner: Player 2: " + clients[rooms[winroomid].Player2].Name + ";0";
                                    foreach (int index in rooms[winroomid].Watchers)
                                    {
                                        clients[index].bWriter = "Play Form Enable;false;Winner: Player 2: " + clients[rooms[winroomid].Player2].Name + ";0";
                                    }
                                }
                                break;

                            case "Retry again":
                                int retryroomid = int.Parse(response[1]);
                                string retryplayer = response[2];
                                bool retryopinion = bool.Parse(response[3]);
                                if (retryplayer.Contains("Player 1"))
                                    rooms[retryroomid].Player1_ret = retryopinion;
                                else if (retryplayer.Contains("Player 2"))
                                    rooms[retryroomid].Player2_ret = retryopinion;
                                if (rooms[retryroomid].Player1_ret == true && rooms[retryroomid].Player2_ret == true)
                                {
                                    rooms[retryroomid].Word = Get_Word(rooms[retryroomid].Category, rooms[retryroomid].Level);
                                    clients[rooms[retryroomid].Player1].bWriter = "Rebuild Form;" + retryroomid + ";" + rooms[retryroomid].Word + ";" + "Player 1: " + clients[rooms[retryroomid].Player1].Name + ";" + rooms[retryroomid].Winner.Contains("Player 1");
                                    for (int i = 0; i < 05000; i++) ;
                                    clients[rooms[retryroomid].Player2].bWriter = "Rebuild Form;" + retryroomid + ";" + rooms[retryroomid].Word + ";" + "Player 2: " + clients[rooms[retryroomid].Player2].Name + ";" + rooms[retryroomid].Winner.Contains("Player 2");
                                    foreach (int index in rooms[retryroomid].Watchers)
                                    {
                                        clients[index].bWriter = "Rebuild Form;" + retryroomid + ";" + rooms[retryroomid].Word + ";" + rooms[retryroomid].Winner + ";false";
                                    }
                                    rooms[retryroomid].Player1_ret = rooms[retryroomid].Player2_ret = null;
                                }
                                else if (rooms[retryroomid].Player1_ret == false && rooms[retryroomid].Player2_ret == false)
                                {
                                    MessageBox.Show("Refused by Player 1 & 2");
                                    rooms[retryroomid].Player1_ret = rooms[retryroomid].Player2_ret = null;
                                    string score_1 = rooms[retryroomid].GetScore(1).ToString();// return int score for player 1
                                    string score_2 = rooms[retryroomid].GetScore(2).ToString();// return int score for player 2
                                    Save_scoreFile(clients[rooms[retryroomid].Player1].Name, clients[rooms[retryroomid].Player2].Name, score_1, score_2);
                                }
                                else if (rooms[retryroomid].Player1_ret == false && rooms[retryroomid].Player2_ret == true)
                                {
                                    MessageBox.Show("Refused by Player 1");
                                    rooms[retryroomid].Player1_ret = rooms[retryroomid].Player2_ret = null;
                                    string score_1 = rooms[retryroomid].GetScore(1).ToString();// return int score for player 1
                                    string score_2 = rooms[retryroomid].GetScore(2).ToString();// return int score for player 2
                                    Save_scoreFile(clients[rooms[retryroomid].Player1].Name, clients[rooms[retryroomid].Player2].Name, score_1, score_2);

                                }
                                else if (rooms[retryroomid].Player1_ret == true && rooms[retryroomid].Player2_ret == false)
                                {
                                    MessageBox.Show("Refused by Player 2");
                                    rooms[retryroomid].Player1_ret = rooms[retryroomid].Player2_ret = null;
                                    string score_1 = rooms[retryroomid].GetScore(1).ToString();// return int score for player 1
                                    string score_2 = rooms[retryroomid].GetScore(2).ToString();// return int score for player 2
                                    Save_scoreFile(clients[rooms[retryroomid].Player1].Name, clients[rooms[retryroomid].Player2].Name, score_1, score_2);

                                }
                                break;

                            case "Quit Room":
                                int quitroomid = int.Parse(response[1]);
                                int quitplayerid = int.Parse(response[2]);
                                if (rooms[quitroomid].Check_Count() == 1)
                                {
                                    foreach (int index in clients.Keys.ToList())
                                        clients[index].bWriter = "Remove Room;" + quitroomid;
                                    rooms.Remove(quitroomid);
                                }
                                else if (rooms[quitroomid].Check_Count() == 2)
                                {
                                    foreach (int index in clients.Keys.ToList())
                                        clients[index].bWriter = "Change Room Capacity Half;" + quitroomid;
                                    if (quitplayerid == rooms[quitroomid].Player1)
                                    {
                                        rooms[quitroomid].Player1 = rooms[quitroomid].Player2;
                                        rooms[quitroomid].Owner = rooms[quitroomid].Player2;
                                    }
                                    else if (quitplayerid == rooms[quitroomid].Player2)
                                    {
                                    }
                                    rooms[quitroomid].Player2 = 0;
                                }
                                break;

                            default:
                                MessageBox.Show(response[0]);
                                break;
                        }
                        List_ClientMsgs.Items.Add(clients[port].Name + ": " + type);
                        ClientsData.Remove(port);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    MessageBox.Show("There is error happened while reading data.\n" + ex.Message, "Error msg!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.ExitThread();
                }
            }
        }

        private void Check_disconnected()
        {
            while (true)
            {
                try
                {
                    foreach (int index in clients.Keys.ToList())
                    {
                        if (!clients[index].isConnected())
                        {
                            List_Disonnected_endpoint.Items.Add(index);
                            List_Disonnected_name.Items.Add(clients[index].Name);
                            List_Connected_name.Items.RemoveAt(List_Connected_endpoint.FindStringExact(index.ToString()));
                            List_Connected_endpoint.Items.RemoveAt(List_Connected_endpoint.FindStringExact(index.ToString()));
                            clients[index] = null;
                            clients.Remove(index);
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void Save_score(string player1, string player2, string endpoint1, string endpoint2)
        {
            StreamWriter sw;
            string startupPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string path = Path.Combine(startupPath, player1 + "_" + player2 + "_" + endpoint1 + "_" + endpoint2 + ".txt");
            if (!File.Exists(path))
            {
                // Create a file to write to. 
                sw = File.CreateText(path);
                sw.Close();
            }
            else
            {
                File.Open(path, FileMode.Open, FileAccess.Write);
            }
            string text = "";
            foreach (var item in List_ClientMsgs.Items)
            {
                text += item.ToString() + "/n"; // /n to print each item on new line or you omit /n to print text on same line 
            }
            string msg = text;
            File.WriteAllText(path, msg);
            
        }

        private void Save_scoreFile(string player1, string player2, string score_1, string score_2)
        {
            StreamWriter sw = null;
            string startupPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string path = Path.Combine(startupPath, "Logs\\Scores.txt");
            string text = "Player 1: " + player1 + " Score :" + score_1 + " ,Player 2: " + player2 + " Score :" + score_2;
            if (!File.Exists(path))
            {
                // Create a file to write to. 
                sw = File.CreateText(path);
                sw.Write(text);
            }
            else
            {
                sw = File.AppendText(path);
                sw.Write(Environment.NewLine + text);
            }
            sw.Close();
        }

        public static ReaderInfo Strings
        {
            set
            {
                if (ClientsData.ContainsKey(value.port))
                    ClientsData[value.port] = value.reader;
                else
                    ClientsData.Add(value.port, value.reader);
            }
        }

        private void Button_Send_Click(object sender, EventArgs e)
        {
            foreach (int index in List_Connected_endpoint.SelectedItems)
            {
                clients[index].bWriter = textBox1.Text;
            }
            textBox1.Text = String.Empty;
        }

        private void Button_Terminate_Click(object sender, EventArgs e)
        {
            int listindex = List_Connected_endpoint.SelectedIndex;
            if (listindex != -1)
            {
                int index = int.Parse(List_Connected_endpoint.SelectedItem.ToString());
                clients[index].bWriter = "Terminated;";
                clients[index].Disconnect();
            }
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void List_Connected_SelectedIndexChanged(object sender, EventArgs e)
        {
            List_Connected_name.SelectedIndex = ((ListBox)sender).SelectedIndex;
            List_Connected_endpoint.SelectedIndex = ((ListBox)sender).SelectedIndex;
        }

        private void List_Disonnected_SelectedIndexChanged(object sender, EventArgs e)
        {
            List_Disonnected_name.SelectedIndex = ((ListBox)sender).SelectedIndex;
            List_Disonnected_endpoint.SelectedIndex = ((ListBox)sender).SelectedIndex;
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            thread1 = new Thread(ClientCreator);
            thread1.Priority = ThreadPriority.BelowNormal;
            thread2 = new Thread(DataReader);
            thread2.Priority = ThreadPriority.Highest;
            thread3 = new Thread(Check_disconnected);
            thread3.Priority = ThreadPriority.Lowest;
            thread1.Start();
            thread2.Start();
            thread3.Start();
            Button_Start.Enabled = false;
            Button_Stop.Enabled = true;
        }

        private void Button_Stop_Click(object sender, EventArgs e)
        {
            Button_Start.Enabled = true;
            Button_Stop.Enabled = false;
        }

        private string Get_Word(string newroomcat, int newroomlvl)
        {
            string affected = "Test";
            try
            {
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "Get_Word";
                SqlParameter[] par =
                    {
                    new SqlParameter("@cat",newroomcat),
                    new SqlParameter("@lvl",newroomlvl)
                };
                com.Parameters.Clear();
                com.Parameters.AddRange(par);
                con.Open();
                affected = com.ExecuteScalar().ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return affected;
        }

        private List<string> Get_Categories()
        {
            DataTable table = new DataTable();
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from Categories";
            com.Connection = con;
            List<string> cats = new List<string>();
            con.Open();
            SqlDataReader rdr = com.ExecuteReader();
            while (rdr.Read())
            {
                cats.Add(Convert.ToString(rdr[0]));
            }
            rdr.Close();
            con.Close();
            return cats;
        }

        private void Button_Restart(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Controller_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (int index in clients.Keys.ToList())
            {
                clients[index].Disconnect();
            }
            Application.ExitThread();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            string word = textBox_Word.Text;
            string cat = textBox_Category.Text;
            int lvl = int.Parse(comboBox_level.Text);
            Insert_word(cat, lvl, word);
            textBox_Word.Text = String.Empty;
            textBox_Category.Text = String.Empty;
            comboBox_level.SelectedIndex = 0;
        }

        private void Button_Log_Click(object sender, EventArgs e)
        {
            string startupPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string path = Path.Combine(startupPath, "Logs\\Log.txt");
            if (!File.Exists(path))
                File.CreateText(path);
            string text = String.Empty;
            foreach (var item in List_ClientMsgs.Items)
            {
                text += item.ToString() + Environment.NewLine;
            }
            File.AppendAllText(path, text);
        }

        private void Insert_word(string cat, int lvl, string word)
        {
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "ADD_word";
            SqlParameter[] par =
                {
                    new SqlParameter("@cat",cat),
                    new SqlParameter("@lvl",lvl),
                    new SqlParameter("@word",word)
                };
            com.Parameters.Clear();
            com.Parameters.AddRange(par);
            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
    }

    public struct ReaderInfo
    {
        public int port;
        public string reader;
    }

    public class Clients
    {
        private Socket socket;
        private NetworkStream nStream;
        private BinaryReader breader;
        private BinaryWriter bwriter;
        private Thread thread;
        private int endpoint;
        private string name;
        public string bWriter { set { try { bwriter.Write(value); } catch (Exception) { Disconnect(); } } }
        public int Endpoint { get { return endpoint; } }
        public string Name { get { return name; } }

        public Clients(Socket socket)
        {
            this.socket = socket;
            endpoint = int.Parse(socket.RemoteEndPoint.ToString().Split(':')[1]);
            nStream = new NetworkStream(socket);
            breader = new BinaryReader(nStream);
            bwriter = new BinaryWriter(nStream);
            name = breader.ReadString();
            bWriter = endpoint.ToString();

            thread = new Thread(new ThreadStart(DataRead));
            thread.Start();
        }

        private void DataRead()
        {
            while (true)
            {
                try
                {
                    ReaderInfo data = new ReaderInfo
                    {
                        port = endpoint,
                        reader = breader.ReadString()
                    };
                    Controller.Strings = data;
                }
                catch (Exception) { Disconnect(); }
            }
        }

        public bool isConnected()
        {
            bool connected = true;
            if (socket.Poll(0, SelectMode.SelectRead) && socket.Available == 0)
                connected = false;
            return connected;
        }

        public void Disconnect()
        {
            thread.Abort();
            breader.Close();
            bwriter.Close();
            nStream.Close();
        }
    }

    public class Room
    {
        private int player1, player2, owner, winner, level;
        private string name, category, word, current_player;
        private List<int> watchers;
        private string pressed = String.Empty;
        private bool? player1_ret = null, player2_ret = null;
        private Dictionary<int, int> win_counter;

        public Room(int Owner, string Name, string Category, int Level, string Word)
        {
            this.owner = Owner;
            this.player1 = Owner;
            this.name = Name;
            this.category = Category;
            this.level = Level;
            this.word = Word;
            this.watchers = new List<int>();
            this.win_counter = new Dictionary<int, int>();
            win_counter.Add(player1, 0);
        }

        public string Current
        {
            set { current_player = value; }
            get { return current_player; }
        }

        public int Owner { get { return owner; } set { owner = value; } }
        public int Player1 { get { return player1; } set { player1 = value; } }
        public int Player2 { get { return player2; } set { player2 = value; } }
        public string Name { get { return name; } }
        public string Category { get { return category; } }
        public int Level { get { return level; } }
        public string Word { set { word = value; } get { return word; } }
        public List<int> Watchers { get { return watchers; } }
        public string Pressed { get { return pressed; } }

        public string Winner
        {
            get
            {
                string ret_val;
                if (winner == player1)
                    ret_val = "Player 1";
                else
                    ret_val = "Player 2";
                return ret_val;
            }
        }

        public int Winner_Count
        {
            set
            {
                if (value == 1) win_counter[player1]++;
                if (value == 2) win_counter[player2]++;
            }
        }

        public bool? Player1_ret { get { return player1_ret; } set { player1_ret = value; } }
        public bool? Player2_ret { get { return player2_ret; } set { player2_ret = value; } }

        public void AddPlayer(int Player2)
        {
            if (Check_Count() < 2)
            {
                this.player2 = Player2;
                win_counter.Add(player2, 0);
            }
        }

        public void AddWatcher(int Watcher)
        {
            this.Watchers.Add(Watcher);
        }

        public void AddWinner(int Winner)
        {
            if (Winner == 1)
                this.winner = player1;
            else if (Winner == 2)
                this.winner = player2;
            pressed = String.Empty;
        }

        public void AddPress(string pressed)
        {
            if (this.pressed == String.Empty)
                this.pressed = pressed;
            else
                this.pressed += "," + pressed;
        }

        public int GetScore(int player)
        {
            int ret_val = 0;
            if (player == 1)
                ret_val = win_counter[player1];
            if (player == 2)
                ret_val = win_counter[player2];
            return ret_val;
        }

        public int Check_Count()
        {
            int count = 0;
            if (player1 != 0)
                ++count;
            if (player2 != 0)
                ++count;
            return count;
        }
    }

    public struct Player
    {
        public string Name { get; set; }
        public int ID { get; set; }
    }
}