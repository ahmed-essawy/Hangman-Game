namespace My_TextBox
{
	partial class My_TextBox
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// My_TextBox
			// 
			this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Italic);
			this.ForeColor = System.Drawing.SystemColors.GrayText;
			this.Size = new System.Drawing.Size(200, 24);
			this.Enter += new System.EventHandler(this.TextBox_Enter);
			this.Leave += new System.EventHandler(this.TextBox_Leave);
			this.ResumeLayout(false);

		}

		#endregion
	}
}
