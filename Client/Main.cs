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
        private string temp_str_room_word = null;

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
        }

        private void Watch_Click(object sender, EventArgs e)
        {
            Play game = new Play("Watch", breader, bwriter);
            thread.Abort();
            game.ShowDialog();
            thread.Start();
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((ListBox)sender).SelectedIndex;
            ListBox_ID.SelectedIndex = index;
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
            cats = cats.Substring(0, cats.Length - 1); // Remove last ;
            Rules NewRules = new Rules(cats);
            NewRules.ShowDialog();
            if (NewRules.DialogResult == DialogResult.OK)
            {
                bwriter.Write("New Room;" + endpoint + ";" + NewRules.Category + ";" + NewRules.Level);
                while (temp_str_room_word == null) ;
                Play game = new Play(temp_str_room_word, breader, bwriter);
                game.ShowDialog();
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            bwriter.Write("Join Room Confirm;" + ListBox_ID.SelectedItem.ToString() + ";" + endpoint);
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
                        ListBox_ID.Items.Add(response[1]);
                        ListBox_Categories.Items.Add(response[2]);
                        ListBox_Levels.Items.Add(response[3]);
                        ListBox_Players.Items.Add(response[4] + "/2");
                        break;

                    case "New Player":
                        DialogResult result = MessageBox.Show(response[3] + " wants to join your room", "Join Confirmation",
                             MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            bwriter.Write("Join Room Reply;" + response[1] + ";" + response[2]);
                            Play game = new Play(response[4], breader, bwriter);
                            game.ShowDialog();
                        }
                        break;

                    case "Room Word":
                        temp_str_room_word = response[1];
                        break;

                    default:
                        MessageBox.Show(response.ToString());
                        break;
                }
            }
        }
    }
}