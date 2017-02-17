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
            Play.Enabled = false;
            Watch.Enabled = false;
            CategList.Enabled = false;
            DiffList.Enabled = false;
            PersonList.Enabled = false;
        }

        private void Watch_Click(object sender, EventArgs e)
        {
            Play game = new Play();
            game.Show();
        }

        private void RoomList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((ListBox)sender).SelectedIndex;
            RoomList.SelectedIndex = index;
            CategList.SelectedIndex = index;
            DiffList.SelectedIndex = index;
            PersonList.SelectedIndex = index;
            string person = PersonList.SelectedItem.ToString();
            if (person == "2/2") { Watch.Enabled = true; Play.Enabled = false; }
            else { Watch.Enabled = false; Play.Enabled = true; }
        }

        private void New_Click(object sender, EventArgs e)
        {
            Rules NewRules = new Rules();
            NewRules.ShowDialog();
            string Category = string.Empty;
            int Level = 0, x = 1000;
            if (NewRules.DialogResult == DialogResult.OK)
            {
                Category = NewRules.Cat;
                Level = NewRules.Level;
            }
            string send = "newroom;" + x + ";" + Category + ";" + Level.ToString();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Play game = new Play();
            game.Show();
        }
    }
}