namespace BroadcastListener
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShowChildFormButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SimpleMessageToChildTextBox = new System.Windows.Forms.TextBox();
            this.SendButton1 = new System.Windows.Forms.Button();
            this.FromForm2TextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ShowChildFormButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 56);
            this.panel1.TabIndex = 0;
            // 
            // ShowChildFormButton
            // 
            this.ShowChildFormButton.Location = new System.Drawing.Point(16, 17);
            this.ShowChildFormButton.Name = "ShowChildFormButton";
            this.ShowChildFormButton.Size = new System.Drawing.Size(75, 23);
            this.ShowChildFormButton.TabIndex = 1;
            this.ShowChildFormButton.Text = "Show child";
            this.ShowChildFormButton.UseVisualStyleBackColor = true;
            this.ShowChildFormButton.Click += new System.EventHandler(this.ShowChildFormButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(497, 21);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Exit";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "String to child form";
            // 
            // SimpleMessageToChildTextBox
            // 
            this.SimpleMessageToChildTextBox.Location = new System.Drawing.Point(104, 14);
            this.SimpleMessageToChildTextBox.Name = "SimpleMessageToChildTextBox";
            this.SimpleMessageToChildTextBox.Size = new System.Drawing.Size(281, 20);
            this.SimpleMessageToChildTextBox.TabIndex = 2;
            // 
            // SendButton1
            // 
            this.SendButton1.Location = new System.Drawing.Point(391, 11);
            this.SendButton1.Name = "SendButton1";
            this.SendButton1.Size = new System.Drawing.Size(75, 23);
            this.SendButton1.TabIndex = 3;
            this.SendButton1.Text = "Send";
            this.SendButton1.UseVisualStyleBackColor = true;
            this.SendButton1.Click += new System.EventHandler(this.SendButton1_Click);
            // 
            // FromForm2TextBox
            // 
            this.FromForm2TextBox.Location = new System.Drawing.Point(104, 40);
            this.FromForm2TextBox.Name = "FromForm2TextBox";
            this.FromForm2TextBox.Size = new System.Drawing.Size(281, 20);
            this.FromForm2TextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 224);
            this.Controls.Add(this.FromForm2TextBox);
            this.Controls.Add(this.SendButton1);
            this.Controls.Add(this.SimpleMessageToChildTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Move += new System.EventHandler(this.Form1_Move);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ShowChildFormButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SimpleMessageToChildTextBox;
        private System.Windows.Forms.Button SendButton1;
        private System.Windows.Forms.TextBox FromForm2TextBox;
    }
}

