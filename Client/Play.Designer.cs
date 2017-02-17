namespace Client
{
    partial class Play
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
            this.panel_labels = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_rules = new System.Windows.Forms.Button();
            this.keyboard1 = new Client.Keyboard();
            this.SuspendLayout();
            // 
            // panel_labels
            // 
            this.panel_labels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel_labels.BackColor = System.Drawing.Color.White;
            this.panel_labels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_labels.Location = new System.Drawing.Point(28, 12);
            this.panel_labels.Name = "panel_labels";
            this.panel_labels.Size = new System.Drawing.Size(420, 96);
            this.panel_labels.TabIndex = 0;
            this.panel_labels.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_labels_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_rules
            // 
            this.button_rules.Location = new System.Drawing.Point(124, 283);
            this.button_rules.Name = "button_rules";
            this.button_rules.Size = new System.Drawing.Size(75, 23);
            this.button_rules.TabIndex = 3;
            this.button_rules.Text = "Rules";
            this.button_rules.UseVisualStyleBackColor = true;
            // 
            // keyboard1
            // 
            this.keyboard1.Location = new System.Drawing.Point(12, 117);
            this.keyboard1.Name = "keyboard1";
            this.keyboard1.Size = new System.Drawing.Size(450, 160);
            this.keyboard1.TabIndex = 4;
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(482, 321);
            this.Controls.Add(this.keyboard1);
            this.Controls.Add(this.button_rules);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_labels);
            this.Name = "Play";
            this.Text = "Play";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_labels;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_rules;
        private Keyboard keyboard1;
    }
}