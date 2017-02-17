using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Play : Form
    {
        string word;
        int len;
        Label[] labels;
        public Play()
        {
            InitializeComponent();
        }
        public Play(string word)
        {
            InitializeComponent();
            word = "Ahmed Mohamedsss11255555598888sssssssssssssssssssssssssss";
            len = word.Length;
            labels = new Label[len];
        }
        public Play(bool watched)
        {
            if (watched == true)
            {
                this.Enabled = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int x = 30;
            int y = 50;
            for (int i = 0; i < len; i++)
            {
                labels[i] = new Label();
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
                labels[i].Text = "_";
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