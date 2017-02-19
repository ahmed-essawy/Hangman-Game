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
    public partial class Rules : Form
    {
        private string[] cats;
        private string room_name;
        private string category;
        private int level;

        public Rules(String categories)
        {
            InitializeComponent();
            cats = categories.Split(';');
            foreach (string item in cats)
            {
                comboBox_cat.Items.Add(item);
            }
            for (int i = 1; i <= 3; i++)
            {
                comboBox_level.Items.Add(i);
            }
            comboBox_cat.SelectedIndex = 0;
            comboBox_level.SelectedIndex = 0;
        }

        public string Room_name { get { return room_name; } }
        public string Category { get { return category; } }
        public int Level { get { return level; } }

        private void Button_Create_Click(object sender, EventArgs e)
        {
            room_name = textBox1.Text;
            category = comboBox_cat.SelectedItem.ToString();
            level = int.Parse(comboBox_level.SelectedItem.ToString());
            DialogResult = DialogResult.OK;
        }
    }
}