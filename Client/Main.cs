using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Main : Form
    {
        private string Username;
        private NetworkStream nStream;

        public Main(NetworkStream nStream, String Username)
        {
            InitializeComponent();
            this.nStream = nStream;
            this.Username = Username;
            MessageBox.Show(Username);
        }
    }
}