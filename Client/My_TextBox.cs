using System;
using System.Windows.Forms;

namespace My_TextBox
{
	public partial class My_TextBox : TextBox
	{
		string stringholder;
		public string PlaceHolder
		{
			get { return this.stringholder; }
			set
			{
				this.stringholder = this.Text = value;
			}
		}
		public My_TextBox()
		{
			InitializeComponent();
		}
		private void TextBox_Leave(object sender, EventArgs e)
		{
			if (this.Text == string.Empty)
			{
				Empty();
			}
		}
		private void TextBox_Enter(object sender, EventArgs e)
		{
			if (this.Text == this.stringholder)
			{
				this.Font = new System.Drawing.Font("Tahoma", 10F);
				this.ForeColor = System.Drawing.SystemColors.WindowText;
				this.Text = String.Empty;
			}
		}
		public void Empty()
		{
			this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Italic);
			this.ForeColor = System.Drawing.SystemColors.GrayText;
			this.Text = this.stringholder;
		}
	}
}
