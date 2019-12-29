namespace BroadcastListener
{
    partial class Form2
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
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StringFromForm1TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StringToForm1TextBox = new System.Windows.Forms.TextBox();
            this.SendToForm1TextBox = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SendToForm1TextBox);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 56);
            this.panel1.TabIndex = 1;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(360, 21);
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
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "String from Form1";
            // 
            // StringFromForm1TextBox
            // 
            this.StringFromForm1TextBox.Location = new System.Drawing.Point(111, 10);
            this.StringFromForm1TextBox.Name = "StringFromForm1TextBox";
            this.StringFromForm1TextBox.Size = new System.Drawing.Size(295, 20);
            this.StringFromForm1TextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "String to Form1";
            // 
            // StringToForm1TextBox
            // 
            this.StringToForm1TextBox.Location = new System.Drawing.Point(111, 39);
            this.StringToForm1TextBox.Name = "StringToForm1TextBox";
            this.StringToForm1TextBox.Size = new System.Drawing.Size(295, 20);
            this.StringToForm1TextBox.TabIndex = 5;
            this.StringToForm1TextBox.Text = "Hello from Form2";
            // 
            // SendToForm1TextBox
            // 
            this.SendToForm1TextBox.Location = new System.Drawing.Point(12, 21);
            this.SendToForm1TextBox.Name = "SendToForm1TextBox";
            this.SendToForm1TextBox.Size = new System.Drawing.Size(75, 23);
            this.SendToForm1TextBox.TabIndex = 1;
            this.SendToForm1TextBox.Text = "Send";
            this.SendToForm1TextBox.UseVisualStyleBackColor = true;
            this.SendToForm1TextBox.Click += new System.EventHandler(this.SendToForm1TextBox_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 224);
            this.Controls.Add(this.StringToForm1TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StringFromForm1TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StringFromForm1TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StringToForm1TextBox;
        private System.Windows.Forms.Button SendToForm1TextBox;
    }
}