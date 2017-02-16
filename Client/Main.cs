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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Hide();
            Login login = new Login();
            DialogResult result = login.ShowDialog();
            if (result != DialogResult.OK)
                Close();
        }
    }
}
