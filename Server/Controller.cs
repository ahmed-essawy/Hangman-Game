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

        public Controller()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            clients = new Dictionary<int, Clients>();
            ClientsData = new Dictionary<int, string>();
            Thread thread1 = new Thread(ClientCreator);
            Thread thread2 = new Thread(DataReader);
            Thread thread3 = new Thread(Check_disconnected);
            thread1.Start();
            thread2.Start();
            thread3.Start();
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
                    List_Connected.Items.Add(temp_client.Name);
                }
            }
        }

        private void DataReader()
        {
            while (true)
            {
                foreach (int port in ClientsData.Keys.ToList())
                {
                    List_ClientMsgs.Items.Add(clients[port].Name + ": " + ClientsData[port]);
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
                        List_Disonnected.Items.Add(index);
                        List_Connected.Items.RemoveAt(List_Connected.FindStringExact(index.ToString()));
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

        private void send_button_Click(object sender, EventArgs e)
        {
            foreach (string item in List_Connected.SelectedItems)
            {
                int index = int.Parse(item);
                clients[index].bWriter = textBox1.Text;
            }
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
        public string bWriter { set { bwriter.Write(value); } }
        public int Endpoint { get { return endpoint; } }
        public string Name { get { return name; } }

        public Clients(Socket socket)
        {
            this.socket = socket;
            endpoint = int.Parse(socket.RemoteEndPoint.ToString().Split(':')[1]);
            name += endpoint;
            nStream = new NetworkStream(socket);
            breader = new BinaryReader(nStream);
            bwriter = new BinaryWriter(nStream);
            thread = new Thread(new ThreadStart(DataRead));
            thread.Start();
        }

        private void DataRead()
        {
            while (true)
            {
                ReaderInfo data = new ReaderInfo
                {
                    port = endpoint,
                    reader = breader.ReadString()
                };
                Controller.Strings = data;
            }
        }

        public bool isConnected()
        {
            bool connected = true;
            //MessageBox.Show(name + " " + socket.Poll(1000, SelectMode.SelectRead));
            if (socket.Poll(1000, SelectMode.SelectRead) && socket.Available == 0)
                connected = false;
            return connected;
        }

        ~Clients()
        {
            breader.Close();
            bwriter.Close();
            nStream.Close();
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();
        }
    }
}