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
            this.Play = new System.Windows.Forms.Button();
            this.Watch = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ListBox_Players = new System.Windows.Forms.ListBox();
            this.ListBox_Levels = new System.Windows.Forms.ListBox();
            this.ListBox_Categories = new System.Windows.Forms.ListBox();
            this.ListBox_ID = new System.Windows.Forms.ListBox();
            this.ListBox_Rooms = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Orange;
            this.Play.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.ForeColor = System.Drawing.Color.Maroon;
            this.Play.Location = new System.Drawing.Point(558, 227);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(130, 51);
            this.Play.TabIndex = 1;
            this.Play.Text = "Join";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Watch
            // 
            this.Watch.BackColor = System.Drawing.Color.Orange;
            this.Watch.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Watch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Watch.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Watch.ForeColor = System.Drawing.Color.Maroon;
            this.Watch.Location = new System.Drawing.Point(558, 295);
            this.Watch.Name = "Watch";
            this.Watch.Size = new System.Drawing.Size(130, 51);
            this.Watch.TabIndex = 2;
            this.Watch.Text = "Watch";
            this.Watch.UseVisualStyleBackColor = false;
            this.Watch.Click += new System.EventHandler(this.Watch_Click);
            // 
            // New
            // 
            this.New.BackColor = System.Drawing.Color.Orange;
            this.New.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.ForeColor = System.Drawing.Color.Maroon;
            this.New.Location = new System.Drawing.Point(558, 155);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(130, 51);
            this.New.TabIndex = 3;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = false;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ListBox_Players);
            this.panel1.Controls.Add(this.ListBox_Levels);
            this.panel1.Controls.Add(this.ListBox_Categories);
            this.panel1.Controls.Add(this.ListBox_ID);
            this.panel1.Controls.Add(this.ListBox_Rooms);
            this.panel1.Location = new System.Drawing.Point(16, 106);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 313);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(438, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Players";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(340, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Levels";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(220, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Categories";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.Orange;
            this.ID.Location = new System.Drawing.Point(33, 4);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(31, 23);
            this.ID.TabIndex = 4;
            this.ID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(127, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rooms";
            // 
            // ListBox_Players
            // 
            this.ListBox_Players.BackColor = System.Drawing.SystemColors.GrayText;
            this.ListBox_Players.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBox_Players.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_Players.ForeColor = System.Drawing.Color.Maroon;
            this.ListBox_Players.FormattingEnabled = true;
            this.ListBox_Players.ItemHeight = 15;
            this.ListBox_Players.Location = new System.Drawing.Point(423, 30);
            this.ListBox_Players.Margin = new System.Windows.Forms.Padding(2);
            this.ListBox_Players.Name = "ListBox_Players";
            this.ListBox_Players.Size = new System.Drawing.Size(99, 270);
            this.ListBox_Players.TabIndex = 3;
            this.ListBox_Players.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // ListBox_Levels
            // 
            this.ListBox_Levels.BackColor = System.Drawing.SystemColors.GrayText;
            this.ListBox_Levels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBox_Levels.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_Levels.ForeColor = System.Drawing.Color.Maroon;
            this.ListBox_Levels.FormattingEnabled = true;
            this.ListBox_Levels.ItemHeight = 15;
            this.ListBox_Levels.Location = new System.Drawing.Point(322, 30);
            this.ListBox_Levels.Margin = new System.Windows.Forms.Padding(2);
            this.ListBox_Levels.Name = "ListBox_Levels";
            this.ListBox_Levels.Size = new System.Drawing.Size(99, 270);
            this.ListBox_Levels.TabIndex = 2;
            this.ListBox_Levels.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // ListBox_Categories
            // 
            this.ListBox_Categories.BackColor = System.Drawing.SystemColors.GrayText;
            this.ListBox_Categories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBox_Categories.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_Categories.ForeColor = System.Drawing.Color.Maroon;
            this.ListBox_Categories.FormattingEnabled = true;
            this.ListBox_Categories.ItemHeight = 15;
            this.ListBox_Categories.Location = new System.Drawing.Point(210, 30);
            this.ListBox_Categories.Margin = new System.Windows.Forms.Padding(2);
            this.ListBox_Categories.Name = "ListBox_Categories";
            this.ListBox_Categories.Size = new System.Drawing.Size(110, 270);
            this.ListBox_Categories.TabIndex = 1;
            this.ListBox_Categories.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // ListBox_ID
            // 
            this.ListBox_ID.BackColor = System.Drawing.SystemColors.GrayText;
            this.ListBox_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBox_ID.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_ID.ForeColor = System.Drawing.Color.Maroon;
            this.ListBox_ID.FormattingEnabled = true;
            this.ListBox_ID.ItemHeight = 15;
            this.ListBox_ID.Location = new System.Drawing.Point(8, 30);
            this.ListBox_ID.Margin = new System.Windows.Forms.Padding(2);
            this.ListBox_ID.Name = "ListBox_ID";
            this.ListBox_ID.Size = new System.Drawing.Size(99, 270);
            this.ListBox_ID.TabIndex = 0;
            this.ListBox_ID.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // ListBox_Rooms
            // 
            this.ListBox_Rooms.BackColor = System.Drawing.SystemColors.GrayText;
            this.ListBox_Rooms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBox_Rooms.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox_Rooms.ForeColor = System.Drawing.Color.Maroon;
            this.ListBox_Rooms.FormattingEnabled = true;
            this.ListBox_Rooms.ItemHeight = 15;
            this.ListBox_Rooms.Location = new System.Drawing.Point(109, 30);
            this.ListBox_Rooms.Margin = new System.Windows.Forms.Padding(2);
            this.ListBox_Rooms.Name = "ListBox_Rooms";
            this.ListBox_Rooms.Size = new System.Drawing.Size(99, 270);
            this.ListBox_Rooms.TabIndex = 0;
            this.ListBox_Rooms.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Jokerman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(149, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(369, 55);
            this.label5.TabIndex = 5;
            this.label5.Text = "HANGMAN GAME";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(701, 430);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Watch);
            this.Controls.Add(this.Play);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Watch;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox ListBox_Players;
        private System.Windows.Forms.ListBox ListBox_Levels;
        private System.Windows.Forms.ListBox ListBox_Categories;
        private System.Windows.Forms.ListBox ListBox_Rooms;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.ListBox ListBox_ID;
        private System.Windows.Forms.Label label5;
    }
}

