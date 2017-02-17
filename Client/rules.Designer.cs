namespace Client
{
    partial class Rules
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
            this.comboBox_cat = new System.Windows.Forms.ComboBox();
            this.comboBox_level = new System.Windows.Forms.ComboBox();
            this.Button_Create = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox_cat
            // 
            this.comboBox_cat.FormattingEnabled = true;
            this.comboBox_cat.Location = new System.Drawing.Point(105, 56);
            this.comboBox_cat.Name = "comboBox_cat";
            this.comboBox_cat.Size = new System.Drawing.Size(121, 21);
            this.comboBox_cat.TabIndex = 2;
            // 
            // comboBox_level
            // 
            this.comboBox_level.FormattingEnabled = true;
            this.comboBox_level.Location = new System.Drawing.Point(105, 93);
            this.comboBox_level.Name = "comboBox_level";
            this.comboBox_level.Size = new System.Drawing.Size(57, 21);
            this.comboBox_level.TabIndex = 3;
            // 
            // Button_Create
            // 
            this.Button_Create.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.Button_Create.Location = new System.Drawing.Point(168, 91);
            this.Button_Create.Name = "Button_Create";
            this.Button_Create.Size = new System.Drawing.Size(58, 23);
            this.Button_Create.TabIndex = 4;
            this.Button_Create.Text = "Create";
            this.Button_Create.UseVisualStyleBackColor = true;
            this.Button_Create.Click += new System.EventHandler(this.Button_Create_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Categories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Levels";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 7;
            // 
            // Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 145);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_Create);
            this.Controls.Add(this.comboBox_level);
            this.Controls.Add(this.comboBox_cat);
            this.Name = "Rules";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Room";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_cat;
        private System.Windows.Forms.ComboBox comboBox_level;
        private System.Windows.Forms.Button Button_Create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
    }
}