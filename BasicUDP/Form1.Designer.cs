namespace BasicUDP
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.TalkToSelfButton = new System.Windows.Forms.Button();
            this.ShowForm2Button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(116, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 108);
            this.listBox1.TabIndex = 1;
            // 
            // TalkToSelfButton
            // 
            this.TalkToSelfButton.Location = new System.Drawing.Point(20, 23);
            this.TalkToSelfButton.Name = "TalkToSelfButton";
            this.TalkToSelfButton.Size = new System.Drawing.Size(75, 23);
            this.TalkToSelfButton.TabIndex = 2;
            this.TalkToSelfButton.Text = "Execute";
            this.TalkToSelfButton.UseVisualStyleBackColor = true;
            this.TalkToSelfButton.Click += new System.EventHandler(this.TalkToSelfButton_Click);
            // 
            // ShowForm2Button
            // 
            this.ShowForm2Button.Location = new System.Drawing.Point(23, 40);
            this.ShowForm2Button.Name = "ShowForm2Button";
            this.ShowForm2Button.Size = new System.Drawing.Size(75, 23);
            this.ShowForm2Button.TabIndex = 3;
            this.ShowForm2Button.Text = "Show child";
            this.ShowForm2Button.UseVisualStyleBackColor = true;
            this.ShowForm2Button.Click += new System.EventHandler(this.ShowForm2Button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Hello from main form";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TalkToSelfButton);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(16, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 150);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Talking to self";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.ShowForm2Button);
            this.groupBox2.Location = new System.Drawing.Point(13, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 154);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Talk to Form2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 371);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code samples";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button TalkToSelfButton;
        private System.Windows.Forms.Button ShowForm2Button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

