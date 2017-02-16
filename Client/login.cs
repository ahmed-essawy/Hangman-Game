using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Client
{
    public partial class Login : Form
    {
        private NetworkStream nstream;

        public Login()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        public NetworkStream nStream { get { return nstream; } }

        public string Username { get { return TextBox_Username.Text; } }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient();
            try
            {
                client.Connect(new IPAddress(new byte[] { 127, 0, 0, 1 }), 5000);
                if (client.Connected)
                {
                    nstream = client.GetStream();
                    DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                DialogResult ConfirmResult = MessageBox.Show("Server not available !\n" + ex.Message,
                                        "Server disconnected",
                                        MessageBoxButtons.RetryCancel);
                if (ConfirmResult == DialogResult.Retry)
                {
                    Login_Click(sender, e);
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
        }
    }
}