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
            this.my_TextBox1 = new My_TextBox.My_TextBox();
            this.SuspendLayout();
            // 
            // Login_btn
            // 
            this.Login_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Login_btn.Location = new System.Drawing.Point(106, 89);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(70, 25);
            this.Login_btn.TabIndex = 2;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(182, 89);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(70, 25);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // my_TextBox1
            // 
            this.my_TextBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Italic);
            this.my_TextBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.my_TextBox1.Location = new System.Drawing.Point(79, 48);
            this.my_TextBox1.Name = "my_TextBox1";
            this.my_TextBox1.PlaceHolder = "Username";
            this.my_TextBox1.Size = new System.Drawing.Size(200, 24);
            this.my_TextBox1.TabIndex = 3;
            this.my_TextBox1.Text = "Username";
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(373, 154);
            this.ControlBox = false;
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.my_TextBox1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Login_btn;
        private My_TextBox.My_TextBox my_TextBox1;
        private System.Windows.Forms.Button Exit;
    }
}