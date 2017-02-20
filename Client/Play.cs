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
        private int space_count = 0;

        public bool Dimmed
        {
            set
            {
                panel1.Enabled = value;
                if (value)
                    panel1.Cursor = Cursors.Hand;
                else
                    panel1.Cursor = Cursors.Default;
            }
        }

        public string Change_Label { set { Label_Current.Text = value; } }
        public int Count { set { count = value; } }

        public Play(string word, int Room_id, int Player_id, string Player_Type, string Pressed, BinaryWriter bWriter)
        {
            InitializeComponent();
            this.room_id = Room_id;
            this.player_id = Player_id;
            this.bWriter = bWriter;
            InitializeWord(word, Player_Type);
            if (Pressed.Contains(","))
                foreach (string letter in Pressed.Split(','))
                    Pressed_Button(letter);
            else if (Pressed != String.Empty && !Pressed.Contains(","))
                Pressed_Button(Pressed);
        }

        private void InitializeWord(string word, string Player_Type)
        {
            this.word = word;
            this.player_type = Player_Type;
            this.Text = Player_Type;
            len = word.Length;
            labels = new Label[len];
            space_count = count = 0;
            int x = 25;
            int y = 75;
            for (int i = 0; i < len; i++)
            {
                labels[i] = new Label();
                labels[i].AutoSize = true;
                labels[i].Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                labels[i].ForeColor = System.Drawing.Color.White;
                labels[i].Size = new System.Drawing.Size(36, 35);
                labels[i].Text = " ";
                if (x < this.Width - 50 - 35)
                {
                    labels[i].Location = new Point(x, y);
                    x += 35;
                }
                else
                {
                    y += 35;
                    x = 25;
                    labels[i].Location = new Point(x, y);
                }
                if (word[i].ToString() == " ")
                {
                    labels[i].Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    ++space_count;
                }
                this.Controls.Add(labels[i]);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            string button_text = ((Button)sender).Text;
            if (word.ToUpper().Contains(button_text))
            {
                for (int i = 0; i < len; i++)
                {
                    if (word[i].ToString().ToUpper() == button_text)
                    {
                        labels[i].Text = word[i].ToString().ToUpper();
                        ++count;
                    }
                }
            }
            else
            {
                panel1.Enabled = false;
                bWriter.Write("Change Control;" + room_id + ";" + player_type + ";" + count);
                for (int i = 0; i < 1000000; i++) ;
            }
             ((Button)sender).Enabled = false;
            bWriter.Write("Button Pressed;" + room_id + ";" + player_type + ";" + button_text);
            for (int j = 0; j < 1000000; j++) ;
            if (count + space_count == word.Length)
            {
                this.panel1.Enabled = false;
                bWriter.Write("Win Game;" + room_id + ";" + player_type);
                Label_Current.Text = "Congratulations !";
                for (int i = 0; i < 100000; i++) ;
                DialogResult result = MessageBox.Show("Do you want to play again ?", "Congratulations !",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                    bWriter.Write("Retry again;" + room_id + ";" + player_type + ";true");
                else
                {
                    bWriter.Write("Retry again;" + room_id + ";" + player_type + ";false");
                    this.Close();
                }
                for (int i = 0; i < 100000; i++) ;
            }
        }

        public void PlayerMessageBox()
        {
            DialogResult result = MessageBox.Show("Do you want to play again ?",
                "Play again !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                bWriter.Write("Retry again;" + room_id + ";" + player_type + ";true");
            else
            {
                bWriter.Write("Retry again;" + room_id + ";" + player_type + ";false");
                this.Close();
            }
        }

        public void Pressed_Button(string letter)
        {
            panel1.Controls.Find("_" + letter, false)[0].Enabled = false;
            for (int i = 0; i < len; i++)
            {
                if (word[i].ToString().ToUpper() == letter.ToUpper())
                {
                    labels[i].Text = word[i].ToString().ToUpper();
                }
            }
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}