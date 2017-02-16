namespace Client
{
    partial class Main
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
            this.separated_ListBox1 = new Client.Separated_ListBox();
            this.Play = new System.Windows.Forms.Button();
            this.Watch = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // separated_ListBox1
            // 
            this.separated_ListBox1.Location = new System.Drawing.Point(-1, 14);
            this.separated_ListBox1.Name = "separated_ListBox1";
            this.separated_ListBox1.Size = new System.Drawing.Size(362, 291);
            this.separated_ListBox1.TabIndex = 0;
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(368, 105);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(75, 23);
            this.Play.TabIndex = 1;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            // 
            // Watch
            // 
            this.Watch.Location = new System.Drawing.Point(368, 139);
            this.Watch.Name = "Watch";
            this.Watch.Size = new System.Drawing.Size(75, 23);
            this.Watch.TabIndex = 2;
            this.Watch.Text = "Watch";
            this.Watch.UseVisualStyleBackColor = true;
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(367, 175);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(75, 23);
            this.New.TabIndex = 3;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 288);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Watch);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.separated_ListBox1);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        private Separated_ListBox separated_ListBox1;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Watch;
        private System.Windows.Forms.Button New;
    }
}

