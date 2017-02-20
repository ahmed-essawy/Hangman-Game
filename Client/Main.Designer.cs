﻿namespace Client
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(335, 69);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(130, 51);
            this.Play.TabIndex = 1;
            this.Play.Text = "Join";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Watch
            // 
            this.Watch.Location = new System.Drawing.Point(335, 126);
            this.Watch.Name = "Watch";
            this.Watch.Size = new System.Drawing.Size(130, 51);
            this.Watch.TabIndex = 2;
            this.Watch.Text = "Watch";
            this.Watch.UseVisualStyleBackColor = true;
            this.Watch.Click += new System.EventHandler(this.Watch_Click);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(335, 12);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(130, 51);
            this.New.TabIndex = 3;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
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
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 519);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 4);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Players";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Levels";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Categories";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(-1, 4);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 4;
            this.ID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rooms";
            // 
            // ListBox_Players
            // 
            this.ListBox_Players.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBox_Players.FormattingEnabled = true;
            this.ListBox_Players.Location = new System.Drawing.Point(234, 19);
            this.ListBox_Players.Margin = new System.Windows.Forms.Padding(2);
            this.ListBox_Players.Name = "ListBox_Players";
            this.ListBox_Players.Size = new System.Drawing.Size(72, 496);
            this.ListBox_Players.TabIndex = 3;
            this.ListBox_Players.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // ListBox_Levels
            // 
            this.ListBox_Levels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBox_Levels.FormattingEnabled = true;
            this.ListBox_Levels.Location = new System.Drawing.Point(195, 19);
            this.ListBox_Levels.Margin = new System.Windows.Forms.Padding(2);
            this.ListBox_Levels.Name = "ListBox_Levels";
            this.ListBox_Levels.Size = new System.Drawing.Size(35, 496);
            this.ListBox_Levels.TabIndex = 2;
            this.ListBox_Levels.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // ListBox_Categories
            // 
            this.ListBox_Categories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBox_Categories.FormattingEnabled = true;
            this.ListBox_Categories.Location = new System.Drawing.Point(128, 19);
            this.ListBox_Categories.Margin = new System.Windows.Forms.Padding(2);
            this.ListBox_Categories.Name = "ListBox_Categories";
            this.ListBox_Categories.Size = new System.Drawing.Size(63, 496);
            this.ListBox_Categories.TabIndex = 1;
            this.ListBox_Categories.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // ListBox_ID
            // 
            this.ListBox_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBox_ID.FormattingEnabled = true;
            this.ListBox_ID.Location = new System.Drawing.Point(2, 19);
            this.ListBox_ID.Margin = new System.Windows.Forms.Padding(2);
            this.ListBox_ID.Name = "ListBox_ID";
            this.ListBox_ID.Size = new System.Drawing.Size(50, 496);
            this.ListBox_ID.TabIndex = 0;
            this.ListBox_ID.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // ListBox_Rooms
            // 
            this.ListBox_Rooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBox_Rooms.FormattingEnabled = true;
            this.ListBox_Rooms.Location = new System.Drawing.Point(56, 19);
            this.ListBox_Rooms.Margin = new System.Windows.Forms.Padding(2);
            this.ListBox_Rooms.Name = "ListBox_Rooms";
            this.ListBox_Rooms.Size = new System.Drawing.Size(68, 496);
            this.ListBox_Rooms.TabIndex = 0;
            this.ListBox_Rooms.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Watch);
            this.Controls.Add(this.Play);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

