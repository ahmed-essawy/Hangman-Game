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
    public partial class rules : Form
    {
        string cat;

        int level;
       

        public string Cat
        {
            get
            {
                return cat;
            }

            set
            {
                cat = value;
            }
        }

        public int Level
        {
            get
            {
                return level;
            }

            set
            {
                level = value;
            }
        }

        public rules()
        {
            InitializeComponent();
        }
        private void button_start_Click(object sender, EventArgs e)
        {
            Cat = comboBox_cat.SelectedItem.ToString();
            Level =int.Parse( comboBox_level.SelectedItem.ToString());
        }
    }
}
