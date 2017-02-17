using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Client
{
    public partial class Play : Form
    {
        private string word;
        private int len;
        private Label[] labels;
        private BinaryReader bReader;
        private BinaryWriter bWriter;
        private Thread thread;

        public Play(string word, BinaryReader bReader, BinaryWriter bWriter, bool disabled = false)
        {
            InitializeComponent();
            this.bReader = bReader;
            this.bWriter = bWriter;
            panel1.Enabled = disabled;
            this.word = word;
            len = word.Length;
            labels = new Label[len];
            thread = new Thread(DataReader);
            thread.Start();
        }

        private void DataReader()
        {
            while (true)
            {
                string[] response = bReader.ReadString().Split(';');
                string type = response[0];
                switch (type)
                {
                    case "Play Form Enable":
                        panel1.Enabled = bool.Parse(response[1]);
                        break;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 30;
            int y = 50;
            for (int i = 0; i < len; i++)
            {
                labels[i] = new Label();
                labels[i].Text = "_";
                labels[i].Size = new Size(20, 16);
                if (x < this.Width - 50)
                {
                    labels[i].Location = new Point(x, y);
                    x += 50;
                }
                else
                {
                    y += 50;
                    x = 10;
                    labels[i].Location = new Point(x, y);
                }
                if (word[i].ToString() == " ")
                {
                    labels[i].Text = " ";
                }
                this.Controls.Add(labels[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = word.ToUpper();
            if ((str1).Contains(((Button)sender).Text))
            {
                for (int i = 0; i < len; i++)
                {
                    if (str1[i].ToString() == (((Button)sender).Text))
                    {
                        labels[i].Text = ((Button)sender).Text.ToString();
                    }
                    Invalidate();
                    ((Button)sender).Enabled = false;
                }
            }
        }
    }
}