using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Main : Form
    {
        private string Username;
        private int endpoint;
        private NetworkStream nStream;
        private BinaryReader breader;
        private BinaryWriter bwriter;

        public Main(NetworkStream nStream, String Username)
        {
            InitializeComponent();
            this.nStream = nStream;
            this.Username = Username;
            bwriter = new BinaryWriter(nStream);
            breader = new BinaryReader(nStream);
            bwriter.Write(Username);
            endpoint = int.Parse(breader.ReadString());
        }
    }
}