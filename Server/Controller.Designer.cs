namespace Server
{
    partial class Controller
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
            this.List_Connected_endpoint = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.List_Disonnected_endpoint = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Button_Send = new System.Windows.Forms.Button();
            this.List_ClientMsgs = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Button_Terminate = new System.Windows.Forms.Button();
            this.Button_S1 = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_Start = new System.Windows.Forms.Button();
            this.Button_Stop = new System.Windows.Forms.Button();
            this.Button_S2 = new System.Windows.Forms.Button();
            this.Button_Restar = new System.Windows.Forms.Button();
            this.List_Connected_name = new System.Windows.Forms.ListBox();
            this.List_Disonnected_name = new System.Windows.Forms.ListBox();
            this.comboBox_level = new System.Windows.Forms.ComboBox();
            this.Insert = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.List_Categories = new System.Windows.Forms.ListBox();
            this.textBox_Category = new My_TextBox.My_TextBox();
            this.textBox_Word = new My_TextBox.My_TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // List_Connected_endpoint
            // 
            this.List_Connected_endpoint.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.List_Connected_endpoint.FormattingEnabled = true;
            this.List_Connected_endpoint.ItemHeight = 16;
            this.List_Connected_endpoint.Location = new System.Drawing.Point(30, 44);
            this.List_Connected_endpoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.List_Connected_endpoint.Name = "List_Connected_endpoint";
            this.List_Connected_endpoint.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.List_Connected_endpoint.Size = new System.Drawing.Size(128, 212);
            this.List_Connected_endpoint.TabIndex = 0;
            this.List_Connected_endpoint.SelectedIndexChanged += new System.EventHandler(this.List_Connected_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connected Clients";
            // 
            // List_Disonnected_endpoint
            // 
            this.List_Disonnected_endpoint.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.List_Disonnected_endpoint.Enabled = false;
            this.List_Disonnected_endpoint.FormattingEnabled = true;
            this.List_Disonnected_endpoint.ItemHeight = 16;
            this.List_Disonnected_endpoint.Location = new System.Drawing.Point(30, 284);
            this.List_Disonnected_endpoint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.List_Disonnected_endpoint.Name = "List_Disonnected_endpoint";
            this.List_Disonnected_endpoint.Size = new System.Drawing.Size(128, 164);
            this.List_Disonnected_endpoint.TabIndex = 0;
            this.List_Disonnected_endpoint.SelectedIndexChanged += new System.EventHandler(this.List_Disonnected_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Disconnected Clients";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox1.Location = new System.Drawing.Point(166, 470);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(433, 42);
            this.textBox1.TabIndex = 2;
            // 
            // Button_Send
            // 
            this.Button_Send.BackColor = System.Drawing.Color.Orange;
            this.Button_Send.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Button_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Send.Location = new System.Drawing.Point(610, 470);
            this.Button_Send.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(121, 43);
            this.Button_Send.TabIndex = 3;
            this.Button_Send.Text = "Send";
            this.Button_Send.UseVisualStyleBackColor = false;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // List_ClientMsgs
            // 
            this.List_ClientMsgs.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.List_ClientMsgs.FormattingEnabled = true;
            this.List_ClientMsgs.ItemHeight = 16;
            this.List_ClientMsgs.Location = new System.Drawing.Point(301, 44);
            this.List_ClientMsgs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.List_ClientMsgs.Name = "List_ClientMsgs";
            this.List_ClientMsgs.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.List_ClientMsgs.Size = new System.Drawing.Size(430, 404);
            this.List_ClientMsgs.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Clients Messages";
            // 
            // Button_Terminate
            // 
            this.Button_Terminate.BackColor = System.Drawing.Color.Orange;
            this.Button_Terminate.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Button_Terminate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Terminate.Location = new System.Drawing.Point(759, 44);
            this.Button_Terminate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Terminate.Name = "Button_Terminate";
            this.Button_Terminate.Size = new System.Drawing.Size(152, 62);
            this.Button_Terminate.TabIndex = 3;
            this.Button_Terminate.Text = "Terminate";
            this.Button_Terminate.UseVisualStyleBackColor = false;
            this.Button_Terminate.Click += new System.EventHandler(this.Button_Terminate_Click);
            // 
            // Button_S1
            // 
            this.Button_S1.BackColor = System.Drawing.Color.Orange;
            this.Button_S1.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Button_S1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_S1.Location = new System.Drawing.Point(759, 112);
            this.Button_S1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_S1.Name = "Button_S1";
            this.Button_S1.Size = new System.Drawing.Size(152, 62);
            this.Button_S1.TabIndex = 3;
            this.Button_S1.Text = "-------";
            this.Button_S1.UseVisualStyleBackColor = false;
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackColor = System.Drawing.Color.Orange;
            this.Button_Exit.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Exit.Location = new System.Drawing.Point(759, 458);
            this.Button_Exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(152, 62);
            this.Button_Exit.TabIndex = 3;
            this.Button_Exit.Text = "Exit";
            this.Button_Exit.UseVisualStyleBackColor = false;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_Start
            // 
            this.Button_Start.BackColor = System.Drawing.Color.Orange;
            this.Button_Start.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Button_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Start.Location = new System.Drawing.Point(759, 320);
            this.Button_Start.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(152, 62);
            this.Button_Start.TabIndex = 4;
            this.Button_Start.Text = "Start";
            this.Button_Start.UseVisualStyleBackColor = false;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // Button_Stop
            // 
            this.Button_Stop.BackColor = System.Drawing.Color.Orange;
            this.Button_Stop.Enabled = false;
            this.Button_Stop.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Button_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Stop.Location = new System.Drawing.Point(759, 389);
            this.Button_Stop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Stop.Name = "Button_Stop";
            this.Button_Stop.Size = new System.Drawing.Size(152, 62);
            this.Button_Stop.TabIndex = 4;
            this.Button_Stop.Text = "Stop";
            this.Button_Stop.UseVisualStyleBackColor = false;
            this.Button_Stop.Click += new System.EventHandler(this.Button_Stop_Click);
            // 
            // Button_S2
            // 
            this.Button_S2.BackColor = System.Drawing.Color.Orange;
            this.Button_S2.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Button_S2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_S2.Location = new System.Drawing.Point(759, 181);
            this.Button_S2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_S2.Name = "Button_S2";
            this.Button_S2.Size = new System.Drawing.Size(152, 62);
            this.Button_S2.TabIndex = 3;
            this.Button_S2.Text = "-------";
            this.Button_S2.UseVisualStyleBackColor = false;
            // 
            // Button_Restar
            // 
            this.Button_Restar.BackColor = System.Drawing.Color.Orange;
            this.Button_Restar.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Button_Restar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Restar.Location = new System.Drawing.Point(759, 251);
            this.Button_Restar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button_Restar.Name = "Button_Restar";
            this.Button_Restar.Size = new System.Drawing.Size(152, 62);
            this.Button_Restar.TabIndex = 3;
            this.Button_Restar.Text = "-------";
            this.Button_Restar.UseVisualStyleBackColor = false;
            this.Button_Restar.Click += new System.EventHandler(this.Button_Restart);
            // 
            // List_Connected_name
            // 
            this.List_Connected_name.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.List_Connected_name.FormattingEnabled = true;
            this.List_Connected_name.ItemHeight = 16;
            this.List_Connected_name.Location = new System.Drawing.Point(166, 44);
            this.List_Connected_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.List_Connected_name.Name = "List_Connected_name";
            this.List_Connected_name.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.List_Connected_name.Size = new System.Drawing.Size(128, 212);
            this.List_Connected_name.TabIndex = 0;
            this.List_Connected_name.SelectedIndexChanged += new System.EventHandler(this.List_Connected_SelectedIndexChanged);
            // 
            // List_Disonnected_name
            // 
            this.List_Disonnected_name.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.List_Disonnected_name.Enabled = false;
            this.List_Disonnected_name.FormattingEnabled = true;
            this.List_Disonnected_name.ItemHeight = 16;
            this.List_Disonnected_name.Location = new System.Drawing.Point(166, 284);
            this.List_Disonnected_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.List_Disonnected_name.Name = "List_Disonnected_name";
            this.List_Disonnected_name.Size = new System.Drawing.Size(128, 164);
            this.List_Disonnected_name.TabIndex = 0;
            this.List_Disonnected_name.SelectedIndexChanged += new System.EventHandler(this.List_Disonnected_SelectedIndexChanged);
            // 
            // comboBox_level
            // 
            this.comboBox_level.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.comboBox_level.FormattingEnabled = true;
            this.comboBox_level.Location = new System.Drawing.Point(135, 3);
            this.comboBox_level.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_level.Name = "comboBox_level";
            this.comboBox_level.Size = new System.Drawing.Size(56, 24);
            this.comboBox_level.TabIndex = 5;
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.Orange;
            this.Insert.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert.Location = new System.Drawing.Point(444, 0);
            this.Insert.Margin = new System.Windows.Forms.Padding(2);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(121, 30);
            this.Insert.TabIndex = 8;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_Category);
            this.panel1.Controls.Add(this.Insert);
            this.panel1.Controls.Add(this.textBox_Word);
            this.panel1.Controls.Add(this.comboBox_level);
            this.panel1.Location = new System.Drawing.Point(166, 521);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 36);
            this.panel1.TabIndex = 10;
            // 
            // List_Categories
            // 
            this.List_Categories.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.List_Categories.FormattingEnabled = true;
            this.List_Categories.ItemHeight = 16;
            this.List_Categories.Location = new System.Drawing.Point(30, 468);
            this.List_Categories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.List_Categories.Name = "List_Categories";
            this.List_Categories.Size = new System.Drawing.Size(128, 84);
            this.List_Categories.TabIndex = 11;
            // 
            // textBox_Category
            // 
            this.textBox_Category.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox_Category.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Italic);
            this.textBox_Category.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Category.Location = new System.Drawing.Point(0, 3);
            this.textBox_Category.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Category.Name = "textBox_Category";
            this.textBox_Category.PlaceHolder = "Category";
            this.textBox_Category.Size = new System.Drawing.Size(128, 24);
            this.textBox_Category.TabIndex = 9;
            this.textBox_Category.Text = "Category";
            // 
            // textBox_Word
            // 
            this.textBox_Word.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBox_Word.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Italic);
            this.textBox_Word.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_Word.Location = new System.Drawing.Point(198, 4);
            this.textBox_Word.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_Word.Name = "textBox_Word";
            this.textBox_Word.PlaceHolder = "Word";
            this.textBox_Word.Size = new System.Drawing.Size(235, 24);
            this.textBox_Word.TabIndex = 9;
            this.textBox_Word.Text = "Word";
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(938, 583);
            this.ControlBox = false;
            this.Controls.Add(this.List_Categories);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Button_Stop);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_Restar);
            this.Controls.Add(this.Button_S2);
            this.Controls.Add(this.Button_S1);
            this.Controls.Add(this.Button_Terminate);
            this.Controls.Add(this.Button_Send);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.List_ClientMsgs);
            this.Controls.Add(this.List_Disonnected_name);
            this.Controls.Add(this.List_Disonnected_endpoint);
            this.Controls.Add(this.List_Connected_name);
            this.Controls.Add(this.List_Connected_endpoint);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Controller";
            this.ShowIcon = false;
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Controller_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox List_Connected_endpoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox List_Disonnected_endpoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Button_Send;
        private System.Windows.Forms.ListBox List_ClientMsgs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Button_Terminate;
        private System.Windows.Forms.Button Button_S1;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.Button Button_Stop;
        private System.Windows.Forms.Button Button_S2;
        private System.Windows.Forms.Button Button_Restar;
        private System.Windows.Forms.ListBox List_Connected_name;
        private System.Windows.Forms.ListBox List_Disonnected_name;
        private System.Windows.Forms.ComboBox comboBox_level;
        private System.Windows.Forms.Button Insert;
        private My_TextBox.My_TextBox textBox_Category;
        private My_TextBox.My_TextBox textBox_Word;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox List_Categories;
    }
}