using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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
        private Thread thread;
        private string cats;

        public Main(NetworkStream nStream, String Username)
        {
            InitializeComponent();
            this.nStream = nStream;
            this.Username = Username;
            bwriter = new BinaryWriter(nStream);
            breader = new BinaryReader(nStream);
            bwriter.Write(Username);
            endpoint = int.Parse(breader.ReadString());
            thread = new Thread(DataReader);
            thread.Start();
            Play.Enabled = false;
            Watch.Enabled = false;
            ListBox_Categories.Enabled = false;
            ListBox_Levels.Enabled = false;
            ListBox_Players.Enabled = false;
        }

        private void Watch_Click(object sender, EventArgs e)
        {
            Play game = new Play();
            game.Show();
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((ListBox)sender).SelectedIndex;
            ListBox_Rooms.SelectedIndex = index;
            ListBox_Categories.SelectedIndex = index;
            ListBox_Levels.SelectedIndex = index;
            ListBox_Players.SelectedIndex = index;
            Watch.Enabled = true;
            if (ListBox_Players.SelectedItem.ToString() == "2/2")
                Play.Enabled = false;
            else
                Play.Enabled = true;
        }

        private void New_Click(object sender, EventArgs e)
        {
            cats = cats.Substring(0, cats.Length - 1);
            Rules NewRules = new Rules(cats);
            NewRules.ShowDialog();
            string Category = string.Empty;
            int Level = 0;
            if (NewRules.DialogResult == DialogResult.OK)
            {
                bwriter.Write("New Room;" + endpoint + ";" + NewRules.Category + ";" + NewRules.Level);
                ListBox_Rooms.Items.Add("New Room");
                ListBox_Categories.Items.Add(NewRules.Category);
                ListBox_Levels.Items.Add(NewRules.Level);
                ListBox_Players.Items.Add("1/2");
                Play game = new Play();
                game.Show();
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            Play game = new Play();
            game.Show();
        }

        private void DataReader()
        {
            while (true)
            {
                string[] response = breader.ReadString().Split(';');
                string type = response[0];
                switch (type)
                {
                    case "Category":
                        cats += response[1] + ";";
                        break;

                    case "Room":
                        ListBox_Rooms.Items.Add("Room");
                        ListBox_Categories.Items.Add(response[1]);
                        ListBox_Levels.Items.Add(response[2]);
                        ListBox_Players.Items.Add(response[3] + "/2");

                        break;

                    default:
                        break;
                }
            }
        }
    }
}