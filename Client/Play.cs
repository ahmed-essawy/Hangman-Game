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
        private BinaryWriter bWriter;
        private int room_id;
        private int player_id;
        private string player_type;
        private int count = 0;

        public bool Dimmed { set { panel1.Enabled = value; } }
        public string Change_Label { set { Label_Current.Text = value; } }

        public Play(string word, int Room_id, int Player_id, string Player_Type, BinaryWriter bWriter)
        {
            InitializeComponent();
            this.word = word;
            this.room_id = Room_id;
            this.player_id = Player_id;
            this.player_type = Player_Type;
            this.bWriter = bWriter;
            len = word.Length;
            labels = new Label[len];
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
            string button_text = ((Button)sender).Text;
            string str1 = word.ToUpper();
            if (str1.Contains(button_text))
            {
                for (int i = 0; i < len; i++)
                {
                    if (str1[i].ToString() == button_text)
                    {
                        labels[i].Text = button_text;
                        ++count;
                        if (count == len)
                        {
                            MessageBox.Show("End of game");
                        }
                    }
                    Invalidate();
                }
            }
            else
            {
                panel1.Enabled = false;
                bWriter.Write("Change Control;" + room_id + ";" + player_type);
                for (int i = 0; i < 1000000; i++) ;
            }
             ((Button)sender).Enabled = false;
            bWriter.Write("Button Pressed;" + room_id + ";" + player_type + ";" + button_text);
        }

        public void Pressed_Button(string letter)
        {
            panel1.Controls.Find(letter, false)[0].Enabled = false;
            for (int i = 0; i < len; i++)
            {
                if (word[i].ToString().ToUpper() == letter.ToUpper())
                {
                    labels[i].Text = letter;
                }
            }
        }
    }
}