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
            this.Button_S3 = new System.Windows.Forms.Button();
            this.List_Connected_name = new System.Windows.Forms.ListBox();
            this.List_Disonnected_name = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // List_Connected_endpoint
            // 
            this.List_Connected_endpoint.FormattingEnabled = true;
            this.List_Connected_endpoint.Location = new System.Drawing.Point(12, 25);
            this.List_Connected_endpoint.Name = "List_Connected_endpoint";
            this.List_Connected_endpoint.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.List_Connected_endpoint.Size = new System.Drawing.Size(110, 173);
            this.List_Connected_endpoint.TabIndex = 0;
            this.List_Connected_endpoint.SelectedIndexChanged += new System.EventHandler(this.List_Connected_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connected Clients";
            // 
            // List_Disonnected_endpoint
            // 
            this.List_Disonnected_endpoint.Enabled = false;
            this.List_Disonnected_endpoint.FormattingEnabled = true;
            this.List_Disonnected_endpoint.Location = new System.Drawing.Point(12, 220);
            this.List_Disonnected_endpoint.Name = "List_Disonnected_endpoint";
            this.List_Disonnected_endpoint.Size = new System.Drawing.Size(110, 134);
            this.List_Disonnected_endpoint.TabIndex = 0;
            this.List_Disonnected_endpoint.SelectedIndexChanged += new System.EventHandler(this.List_Disonnected_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Disconnected Clients";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 376);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 35);
            this.textBox1.TabIndex = 2;
            // 
            // Button_Send
            // 
            this.Button_Send.Location = new System.Drawing.Point(312, 376);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(104, 35);
            this.Button_Send.TabIndex = 3;
            this.Button_Send.Text = "Send";
            this.Button_Send.UseVisualStyleBackColor = true;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // List_ClientMsgs
            // 
            this.List_ClientMsgs.FormattingEnabled = true;
            this.List_ClientMsgs.Location = new System.Drawing.Point(244, 25);
            this.List_ClientMsgs.Name = "List_ClientMsgs";
            this.List_ClientMsgs.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.List_ClientMsgs.Size = new System.Drawing.Size(169, 329);
            this.List_ClientMsgs.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Clients Messages";
            // 
            // Button_Terminate
            // 
            this.Button_Terminate.Location = new System.Drawing.Point(452, 25);
            this.Button_Terminate.Name = "Button_Terminate";
            this.Button_Terminate.Size = new System.Drawing.Size(130, 50);
            this.Button_Terminate.TabIndex = 3;
            this.Button_Terminate.Text = "Terminate";
            this.Button_Terminate.UseVisualStyleBackColor = true;
            this.Button_Terminate.Click += new System.EventHandler(this.Button_Terminate_Click);
            // 
            // Button_S1
            // 
            this.Button_S1.Location = new System.Drawing.Point(452, 81);
            this.Button_S1.Name = "Button_S1";
            this.Button_S1.Size = new System.Drawing.Size(130, 50);
            this.Button_S1.TabIndex = 3;
            this.Button_S1.Text = "-------";
            this.Button_S1.UseVisualStyleBackColor = true;
            // 
            // Button_Exit
            // 
            this.Button_Exit.Location = new System.Drawing.Point(452, 361);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(130, 50);
            this.Button_Exit.TabIndex = 3;
            this.Button_Exit.Text = "Exit";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_Start
            // 
            this.Button_Start.Location = new System.Drawing.Point(452, 249);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(130, 50);
            this.Button_Start.TabIndex = 4;
            this.Button_Start.Text = "Start";
            this.Button_Start.UseVisualStyleBackColor = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // Button_Stop
            // 
            this.Button_Stop.Enabled = false;
            this.Button_Stop.Location = new System.Drawing.Point(452, 305);
            this.Button_Stop.Name = "Button_Stop";
            this.Button_Stop.Size = new System.Drawing.Size(130, 50);
            this.Button_Stop.TabIndex = 4;
            this.Button_Stop.Text = "Stop";
            this.Button_Stop.UseVisualStyleBackColor = true;
            this.Button_Stop.Click += new System.EventHandler(this.Button_Stop_Click);
            // 
            // Button_S2
            // 
            this.Button_S2.Location = new System.Drawing.Point(452, 137);
            this.Button_S2.Name = "Button_S2";
            this.Button_S2.Size = new System.Drawing.Size(130, 50);
            this.Button_S2.TabIndex = 3;
            this.Button_S2.Text = "-------";
            this.Button_S2.UseVisualStyleBackColor = true;
            // 
            // Button_S3
            // 
            this.Button_S3.Location = new System.Drawing.Point(452, 193);
            this.Button_S3.Name = "Button_S3";
            this.Button_S3.Size = new System.Drawing.Size(130, 50);
            this.Button_S3.TabIndex = 3;
            this.Button_S3.Text = "-------";
            this.Button_S3.UseVisualStyleBackColor = true;
            // 
            // List_Connected_name
            // 
            this.List_Connected_name.FormattingEnabled = true;
            this.List_Connected_name.Location = new System.Drawing.Point(128, 25);
            this.List_Connected_name.Name = "List_Connected_name";
            this.List_Connected_name.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.List_Connected_name.Size = new System.Drawing.Size(110, 173);
            this.List_Connected_name.TabIndex = 0;
            this.List_Connected_name.SelectedIndexChanged += new System.EventHandler(this.List_Connected_SelectedIndexChanged);
            // 
            // List_Disonnected_name
            // 
            this.List_Disonnected_name.Enabled = false;
            this.List_Disonnected_name.FormattingEnabled = true;
            this.List_Disonnected_name.Location = new System.Drawing.Point(128, 220);
            this.List_Disonnected_name.Name = "List_Disonnected_name";
            this.List_Disonnected_name.Size = new System.Drawing.Size(110, 134);
            this.List_Disonnected_name.TabIndex = 0;
            this.List_Disonnected_name.SelectedIndexChanged += new System.EventHandler(this.List_Disonnected_SelectedIndexChanged);
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 427);
            this.Controls.Add(this.Button_Stop);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_S3);
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
            this.Name = "Controller";
            this.Text = "Server";
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
        private System.Windows.Forms.Button Button_S3;
        private System.Windows.Forms.ListBox List_Connected_name;
        private System.Windows.Forms.ListBox List_Disonnected_name;
    }
}