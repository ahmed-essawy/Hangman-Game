namespace Client
{
    partial class Separated_ListBox
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Persons = new System.Windows.Forms.ListBox();
            this.Difficulty_Level = new System.Windows.Forms.ListBox();
            this.Category = new System.Windows.Forms.ListBox();
            this.Rooms = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Persons";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Difficulty_Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Rooms";
            // 
            // Persons
            // 
            this.Persons.FormattingEnabled = true;
            this.Persons.Items.AddRange(new object[] {
            "1/2",
            "2/2",
            "2/2",
            "1/2"});
            this.Persons.Location = new System.Drawing.Point(256, 22);
            this.Persons.Name = "Persons";
            this.Persons.Size = new System.Drawing.Size(80, 186);
            this.Persons.TabIndex = 12;
            this.Persons.SelectedIndexChanged += new System.EventHandler(this.Rooms_SelectedIndexChanged);
            // 
            // Difficulty_Level
            // 
            this.Difficulty_Level.FormattingEnabled = true;
            this.Difficulty_Level.Items.AddRange(new object[] {
            "medium",
            "hard",
            "easy",
            "medium"});
            this.Difficulty_Level.Location = new System.Drawing.Point(171, 22);
            this.Difficulty_Level.Name = "Difficulty_Level";
            this.Difficulty_Level.Size = new System.Drawing.Size(80, 186);
            this.Difficulty_Level.TabIndex = 9;
            this.Difficulty_Level.SelectedIndexChanged += new System.EventHandler(this.Rooms_SelectedIndexChanged);
            // 
            // Category
            // 
            this.Category.FormattingEnabled = true;
            this.Category.Items.AddRange(new object[] {
            "cat1",
            "cat2",
            "cat3",
            "cat4"});
            this.Category.Location = new System.Drawing.Point(87, 22);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(80, 186);
            this.Category.TabIndex = 10;
            this.Category.SelectedIndexChanged += new System.EventHandler(this.Rooms_SelectedIndexChanged);
            // 
            // Rooms
            // 
            this.Rooms.FormattingEnabled = true;
            this.Rooms.Items.AddRange(new object[] {
            "Room 1",
            "Room 2",
            "Room 3",
            "Room 4"});
            this.Rooms.Location = new System.Drawing.Point(4, 22);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(80, 186);
            this.Rooms.TabIndex = 11;
            this.Rooms.SelectedIndexChanged += new System.EventHandler(this.Rooms_SelectedIndexChanged);
            // 
            // Separated_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Persons);
            this.Controls.Add(this.Difficulty_Level);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Rooms);
            this.Name = "Separated_ListBox";
            this.Size = new System.Drawing.Size(340, 212);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Persons;
        private System.Windows.Forms.ListBox Difficulty_Level;
        private System.Windows.Forms.ListBox Category;
        private System.Windows.Forms.ListBox Rooms;
    }
}
