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
    public delegate char EventHandler();
        public partial class Keyboard : UserControl
    {
       // public event EventHandler buttons_click;
     

        public Keyboard()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            bt.Enabled = false;
            MessageBox.Show(bt.Text);
        }
     
      
    }
}
