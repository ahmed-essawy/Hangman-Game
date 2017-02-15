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
        public Play()
        {
            InitializeComponent();
        }

        private void panel_labels_Paint(object sender, PaintEventArgs e)
        {

            int ControlNum = 30;
            Label[] lbl_array = new Label[ControlNum];
            for (int i = 0, locx = 10, locy = 30; i < ControlNum; i++, locx += 30)
            {
                lbl_array[i] = new Label();
                lbl_array[i].Name = "lblName" + i;
                lbl_array[i].Size = new Size(10, 10);
                if (locx < this.Width - 50)
                {
                    lbl_array[i].Location = new Point(locx, locy);
                }
                else
                {
                    locy += 50;
                    if (locx / 30 != 1)
                    {
                        locx = 10;
                        lbl_array[i].Location = new Point(locx, locy);
                    }
                }
                lbl_array[i].Text = "-";
                panel_labels.Controls.Add(lbl_array[i]);


            }
        }

        private void Play_Load(object sender, EventArgs e)
        {
            panel_Alpha.Location = new Point(panel_labels.Location.X, panel_labels.Size.Height + 30);
        }

        private void button_rules_Click(object sender, EventArgs e)
        {
            rules rule = new rules();
            DialogResult d = rule.ShowDialog();

            if (d == DialogResult.OK)
            {
            }
        }
    }
}
