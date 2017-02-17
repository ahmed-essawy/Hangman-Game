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
            this.label1 = new System.Windows.Forms.Label();
            this.PersonList = new System.Windows.Forms.ListBox();
            this.DiffList = new System.Windows.Forms.ListBox();
            this.CategList = new System.Windows.Forms.ListBox();
            this.RoomList = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(491, 129);
            this.Play.Margin = new System.Windows.Forms.Padding(4);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(100, 28);
            this.Play.TabIndex = 1;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Watch
            // 
            this.Watch.Location = new System.Drawing.Point(491, 171);
            this.Watch.Margin = new System.Windows.Forms.Padding(4);
            this.Watch.Name = "Watch";
            this.Watch.Size = new System.Drawing.Size(100, 28);
            this.Watch.TabIndex = 2;
            this.Watch.Text = "Watch";
            this.Watch.UseVisualStyleBackColor = true;
            this.Watch.Click += new System.EventHandler(this.Watch_Click);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(489, 215);
            this.New.Margin = new System.Windows.Forms.Padding(4);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(100, 28);
            this.New.TabIndex = 3;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.PersonList);
            this.panel1.Controls.Add(this.DiffList);
            this.panel1.Controls.Add(this.CategList);
            this.panel1.Controls.Add(this.RoomList);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 362);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Persons";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Difficulty_Level";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rooms";
            // 
            // PersonList
            // 
            this.PersonList.FormattingEnabled = true;
            this.PersonList.ItemHeight = 16;
            this.PersonList.Items.AddRange(new object[] {
            "1/2",
            "2/2",
            "2/2",
            "1/2"});
            this.PersonList.Location = new System.Drawing.Point(338, 87);
            this.PersonList.Name = "PersonList";
            this.PersonList.Size = new System.Drawing.Size(94, 196);
            this.PersonList.TabIndex = 3;
            // 
            // DiffList
            // 
            this.DiffList.FormattingEnabled = true;
            this.DiffList.ItemHeight = 16;
            this.DiffList.Items.AddRange(new object[] {
            "medium",
            "hard",
            "easy",
            "medium"});
            this.DiffList.Location = new System.Drawing.Point(226, 87);
            this.DiffList.Name = "DiffList";
            this.DiffList.Size = new System.Drawing.Size(91, 196);
            this.DiffList.TabIndex = 2;
            // 
            // CategList
            // 
            this.CategList.FormattingEnabled = true;
            this.CategList.ItemHeight = 16;
            this.CategList.Items.AddRange(new object[] {
            "cat1",
            "cat2",
            "cat3",
            "cat4"});
            this.CategList.Location = new System.Drawing.Point(127, 87);
            this.CategList.Name = "CategList";
            this.CategList.Size = new System.Drawing.Size(83, 196);
            this.CategList.TabIndex = 1;
            // 
            // RoomList
            // 
            this.RoomList.FormattingEnabled = true;
            this.RoomList.ItemHeight = 16;
            this.RoomList.Items.AddRange(new object[] {
            "Room 1",
            "Room 2",
            "Room 3",
            "Room 4"});
            this.RoomList.Location = new System.Drawing.Point(23, 87);
            this.RoomList.Name = "RoomList";
            this.RoomList.Size = new System.Drawing.Size(89, 196);
            this.RoomList.TabIndex = 0;
            this.RoomList.SelectedIndexChanged += new System.EventHandler(this.RoomList_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 354);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Watch);
            this.Controls.Add(this.Play);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Watch;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox PersonList;
        private System.Windows.Forms.ListBox DiffList;
        private System.Windows.Forms.ListBox CategList;
        private System.Windows.Forms.ListBox RoomList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

