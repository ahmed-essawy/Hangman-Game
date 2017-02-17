using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace Server
{
    public partial class Controller : Form
    {
        private Dictionary<int, Clients> clients;
        private static Dictionary<int, string> ClientsData;
        private Thread thread1, thread2, thread3;
        private Dictionary<int, string> players;
        private List<Room> rooms;
        private List<string> cats;

        public Controller()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            clients = new Dictionary<int, Clients>();
            ClientsData = new Dictionary<int, string>();
            players = new Dictionary<int, string>();
            rooms = new List<Room>();
            cats = new List<string>();
            // Bring data from database
            cats.AddRange(new[] { "Sports", "Mobies", "Actors" });
            Room r1 = new Room(1, "Sports", 1);
            Room r2 = new Room(3, "Movies", 2);
            r2.AddPlayer(50);
            Room r3 = new Room(5, "Sports", 3);
            rooms.AddRange(new[] { r1, r2, r3 });
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
                    foreach (string item in cats)
                    {
                        temp_client.bWriter = "Category;" + item;
                    }
                    foreach (Room item in rooms)
                    {
                        temp_client.bWriter = "Room;" + item.Category + ";" + item.Level + ";" + item.Check_Count();
                    }
                    //players.Add(temp_client.Endpoint, temp_client.Name);
                }
            }
        }

        private void DataReader()
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
                            break;

                        case "New Room":
                            int creator = int.Parse(response[1]);
                            string newroomcat = response[2];
                            int newroomlvl = int.Parse(response[3]);
                            rooms.Add(new Room(creator, newroomcat, newroomlvl));
                            type += " (" + newroomcat + ", lvl" + newroomlvl + ")";
                            break;

                        case "Join Room":
                            int joinroom = int.Parse(response[1]);
                            int player2 = int.Parse(response[2]);
                            rooms[joinroom].AddPlayer(player2);
                            type += " (" + clients[player2].Name + " joined room to play)";
                            break;

                        case "Watch Room":
                            int watchroom = int.Parse(response[1]);
                            int watcher = int.Parse(response[2]);
                            rooms[watchroom].AddWatcher(watcher);
                            type += " (" + clients[watcher].Name + " joined room to watch)";
                            break;

                        case "Win Game":
                            int winnerroom = int.Parse(response[1]);
                            int winner = int.Parse(response[2]);
                            rooms[winnerroom].AddWatcher(winner);
                            type += " (" + clients[winner].Name + " win game)";
                            break;

                        default:
                            break;
                    }
                    List_ClientMsgs.Items.Add(clients[port].Name + ": " + type);
                    ClientsData.Remove(port);
                }
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
            if (socket.Poll(1000, SelectMode.SelectRead) && socket.Available == 0)
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
        private int Player1, Player2, Owner, Winner, level;
        private string category;
        private List<int> Watchers;

        public Room(int Owner, string Category, int Level)
        {
            this.Player1 = Owner;
            this.category = Category;
            this.level = Level;
        }

        public string Category { get { return category; } }
        public int Level { get { return level; } }

        public void AddPlayer(int Player2)
        {
            if (Check_Count() < 2)
                this.Player2 = Player2;
        }

        public void AddWatcher(int Watcher)
        {
            this.Watchers.Add(Watcher);
        }

        public void AddWinner(int Winner)
        {
            this.Winner = Winner;
        }

        public int Check_Count()
        {
            int count = 0;
            if (Player1 != 0)
                ++count;
            if (Player2 != 0)
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