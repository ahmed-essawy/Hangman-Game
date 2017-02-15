using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Client_NS
{
    public partial class Client : Form
    {
        private Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private byte[] buffer = new byte[1024];

        public Client()
        {
            InitializeComponent();
        }

        private void ReceiveData(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            int received = socket.EndReceive(ar);
            byte[] dataBuf = new byte[received];
            Array.Copy(buffer, dataBuf, received);
            lb_stt.Text = (Encoding.ASCII.GetString(dataBuf));
            this.socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveData), this.socket);
        }

        private void SendLoop()
        {
            while (true)
            {
                byte[] receivedBuf = new byte[1024];
                int rev = socket.Receive(receivedBuf);
                if (rev != 0)
                {
                    byte[] data = new byte[rev];
                    Array.Copy(receivedBuf, data, rev);
                    lb_stt.Text = ("Received: " + Encoding.ASCII.GetString(data));
                    listBox1.Items.Add("\nServer: " + Encoding.ASCII.GetString(data));
                }
                else socket.Close();
            }
        }

        private void LoopConnect()
        {
            int attempts = 0;
            while (!socket.Connected)
            {
                try
                {
                    attempts++;
                    socket.Connect(IPAddress.Loopback, 1025);
                }
                catch (Exception) { }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (socket.Connected)
            {
                byte[] buffer = Encoding.ASCII.GetBytes(textBox1.Text);
                socket.Send(buffer);
                listBox1.Items.Add("Client: " + textBox1.Text);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            LoopConnect();
            socket.BeginReceive(this.buffer, 0, this.buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveData), socket);
            byte[] buffer = Encoding.ASCII.GetBytes("Connect: " + txName.Text);
            socket.Send(buffer);
        }
    }
}