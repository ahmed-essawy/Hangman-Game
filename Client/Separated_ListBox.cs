using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Separated_ListBox : UserControl
    {
        public Separated_ListBox()
        {
            InitializeComponent();
        }
        private void Rooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index =((ListBox)sender).SelectedIndex;
            Rooms.SelectedIndex = index;
            Category.SelectedIndex = index;
            Difficulty_Level.SelectedIndex = index;
            Persons.SelectedIndex = index;
           
        }

        public string show_info()
        {
            string room, cat, level, person;
            room = Rooms.SelectedItem.ToString();
            cat = Category.SelectedItem.ToString();
            level = Difficulty_Level.SelectedItem.ToString();
            person = Persons.SelectedItem.ToString();
            return person;
           // MessageBox.Show("Room: " + room + "    Category: " + cat + "    Level: " + level + "    Persons in room: " + person);
        }
    }
}
