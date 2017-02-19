using System;
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
            con = new SqlConnection("Data Source =.; Initial Catalog = HangMan; Integrated Security = True");
            com = new SqlCommand();
            com.Connection = con;
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
                        for (int i = 0; i < 1000000; i++) ;
                    }
                    foreach (int index in rooms.Keys.ToList())
                    {
                        temp_client.bWriter = "Room;" + index + ";" + rooms[index].Name + ";" + rooms[index].Category + ";" + rooms[index].Level + ";" + rooms[index].Check_Count();
                        for (int i = 0; i < 1000000; i++) ;
                    }
                    //players.Add(temp_client.Endpoint, temp_client.Name);
                }
            }
        }

        private void DataReader()
        {
            try
            {
                while (true)
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
                                clients[rooms[joinroom].Player1].bWriter = "Play Form Enable;true;Player 1: " + clients[rooms[joinroom].Player1].Name;
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
                                if (playersendpress == "Player 1")
                                    clients[rooms[roomsendpress].Player2].bWriter = "Dim Button;" + charpressed;
                                else if (playersendpress == "Player 2")
                                    clients[rooms[roomsendpress].Player1].bWriter = "Dim Button;" + charpressed;
                                foreach (int index in rooms[roomsendpress].Watchers)
                                {
                                    clients[index].bWriter = "Dim Button;" + charpressed;
                                }
                                rooms[roomsendpress].AddPress(charpressed);
                                type += " (" + playersendpress + " press " + response[3] + ")";
                                break;

                            case "Change Control":
                                int roomsendchange = int.Parse(response[1]);
                                string playersendchange = response[2];
                                if (playersendchange.Contains("Player 1"))
                                {
                                    rooms[roomsendchange].Current = "Player 2";
                                    clients[rooms[roomsendchange].Player1].bWriter = "Play Form Enable;false;Player 2: " + clients[rooms[roomsendchange].Player2].Name;
                                    clients[rooms[roomsendchange].Player2].bWriter = "Play Form Enable;true;Your Turn";
                                    foreach (int index in rooms[roomsendchange].Watchers)
                                    {
                                        clients[index].bWriter = "Play Form Enable;false;Player 2: " + clients[rooms[roomsendchange].Player2].Name;
                                    }
                                }
                                else if (playersendchange.Contains( "Player 2"))
                                {
                                    rooms[roomsendchange].Current = "Player 1";
                                    clients[rooms[roomsendchange].Player1].bWriter = "Play Form Enable;true;Your Turn";
                                    clients[rooms[roomsendchange].Player2].bWriter = "Play Form Enable;false;Player 1: " + clients[rooms[roomsendchange].Player1].Name;
                                    foreach (int index in rooms[roomsendchange].Watchers)
                                    {
                                        clients[index].bWriter = "Play Form Enable;false;Player 1: " + clients[rooms[roomsendchange].Player1].Name;
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

                            default:
                                break;
                        }
                        List_ClientMsgs.Items.Add(clients[port].Name + ": " + type);
                        ClientsData.Remove(port);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is error happened while reading data.\nPlease, restart server.\n" + ex.Message, "Error msg!", MessageBoxButtons.OK);
                Application.Exit();
            }
        }

        private void Check_disconnected()
        {
            while (true)
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
        }

        private void Button_Terminate_Click(object sender, EventArgs e)
        {
            /*foreach (string item in List_Connected_endpoint.SelectedItems)
            {
                        List_Disonnected_endpoint.Items.Add(index);
                        List_Disonnected_name.Items.Add(clients[index].Name);
                        List_Connected_name.Items.RemoveAt(List_Connected_endpoint.FindStringExact(index.ToString()));
                        List_Connected_endpoint.Items.RemoveAt(List_Connected_endpoint.FindStringExact(index.ToString()));
                clients[index] = null;
                clients.Remove(index);
            }*/
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
            thread2 = new Thread(DataReader);
            thread3 = new Thread(Check_disconnected);
            thread1.Start();
            thread2.Start();
            thread3.Start();
            Button_Start.Enabled = false;
            Button_Stop.Enabled = true;
        }

        private void Button_Stop_Click(object sender, EventArgs e)
        {
            thread1.Abort();
            thread2.Abort();
            thread3.Abort();
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

        private void Disconnect()
        {
            thread.Abort();
            breader.Close();
            bwriter.Close();
            nStream.Close();
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
    }

    public class Room
    {
        private int player1, player2, owner, Winner, level;
        private string name, category, word, current_player;
        private List<int> watchers;
        private string pressed = String.Empty;

        public Room(int Owner, string Name, string Category, int Level, string Word)
        {
            this.owner = Owner;
            this.player1 = Owner;
            this.name = Name;
            this.category = Category;
            this.level = Level;
            this.word = Word;
            this.watchers = new List<int>();
        }

        public int Owner { get { return owner; } }
        public int Player1 { get { return player1; } }
        public int Player2 { get { return player2; } }
        public string Name { get { return name; } }
        public string Category { get { return category; } }
        public int Level { get { return level; } }
        public string Word { get { return word; } }
        public List<int> Watchers { get { return watchers; } }

        public string Current
        {
            set { current_player = value; }
            get { return current_player; }
        }

        public string Pressed { get { return pressed; } }

        public void AddPlayer(int Player2)
        {
            if (Check_Count() < 2)
                this.player2 = Player2;
        }

        public void AddWatcher(int Watcher)
        {
            this.Watchers.Add(Watcher);
        }

        public void AddWinner(int Winner)
        {
            this.Winner = Winner;
        }

        public void AddPress(string pressed)
        {
            if (this.pressed == String.Empty)
                this.pressed = pressed;
            else
                this.pressed += "," + pressed;
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