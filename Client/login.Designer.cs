namespace Client
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_btn = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextBox_Username = new My_TextBox.My_TextBox();
            this.IpAddress = new My_TextBox.My_TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.Orange;
            this.Login_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Login_btn.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btn.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.ForeColor = System.Drawing.Color.Maroon;
            this.Login_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Login_btn.Location = new System.Drawing.Point(245, 83);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(70, 25);
            this.Login_btn.TabIndex = 2;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Orange;
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Maroon;
            this.Exit.Location = new System.Drawing.Point(321, 83);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(70, 25);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Client.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 129);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // TextBox_Username
            // 
            this.TextBox_Username.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextBox_Username.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Username.ForeColor = System.Drawing.Color.Maroon;
            this.TextBox_Username.Location = new System.Drawing.Point(178, 50);
            this.TextBox_Username.Name = "TextBox_Username";
            this.TextBox_Username.PlaceHolder = "Nickname";
            this.TextBox_Username.Size = new System.Drawing.Size(213, 26);
            this.TextBox_Username.TabIndex = 3;
            this.TextBox_Username.Text = "Nickname";
            this.TextBox_Username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_Username_KeyDown);
            // 
            // IpAddress
            // 
            this.IpAddress.BackColor = System.Drawing.SystemColors.ControlLight;
            this.IpAddress.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IpAddress.ForeColor = System.Drawing.Color.Maroon;
            this.IpAddress.Location = new System.Drawing.Point(178, 82);
            this.IpAddress.Name = "IpAddress";
            this.IpAddress.PlaceHolder = "127.0.0.1";
            this.IpAddress.Size = new System.Drawing.Size(61, 26);
            this.IpAddress.TabIndex = 6;
            this.IpAddress.Text = "127.0.0.1";
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(439, 154);
            this.ControlBox = false;
            this.Controls.Add(this.IpAddress);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.TextBox_Username);
            this.Controls.Add(this.Login_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Login_btn;
        private My_TextBox.My_TextBox TextBox_Username;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private My_TextBox.My_TextBox IpAddress;
    }
}