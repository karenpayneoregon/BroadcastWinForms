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
            this.IntButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.IntButton);
            this.panel1.Controls.Add(this.ShowChildFormButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 207);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 69);
            this.panel1.TabIndex = 0;
            // 
            // ShowChildFormButton
            // 
            this.ShowChildFormButton.Location = new System.Drawing.Point(21, 21);
            this.ShowChildFormButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowChildFormButton.Name = "ShowChildFormButton";
            this.ShowChildFormButton.Size = new System.Drawing.Size(100, 28);
            this.ShowChildFormButton.TabIndex = 1;
            this.ShowChildFormButton.Text = "Show child";
            this.ShowChildFormButton.UseVisualStyleBackColor = true;
            this.ShowChildFormButton.Click += new System.EventHandler(this.ShowChildFormButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(663, 26);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 28);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "Exit";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "String to child form";
            // 
            // SimpleMessageToChildTextBox
            // 
            this.SimpleMessageToChildTextBox.Location = new System.Drawing.Point(139, 17);
            this.SimpleMessageToChildTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SimpleMessageToChildTextBox.Name = "SimpleMessageToChildTextBox";
            this.SimpleMessageToChildTextBox.Size = new System.Drawing.Size(373, 22);
            this.SimpleMessageToChildTextBox.TabIndex = 2;
            // 
            // SendButton1
            // 
            this.SendButton1.Location = new System.Drawing.Point(521, 14);
            this.SendButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SendButton1.Name = "SendButton1";
            this.SendButton1.Size = new System.Drawing.Size(100, 28);
            this.SendButton1.TabIndex = 3;
            this.SendButton1.Text = "Send";
            this.SendButton1.UseVisualStyleBackColor = true;
            this.SendButton1.Click += new System.EventHandler(this.SendButton1_Click);
            // 
            // FromForm2TextBox
            // 
            this.FromForm2TextBox.Location = new System.Drawing.Point(139, 49);
            this.FromForm2TextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FromForm2TextBox.Name = "FromForm2TextBox";
            this.FromForm2TextBox.Size = new System.Drawing.Size(373, 22);
            this.FromForm2TextBox.TabIndex = 4;
            // 
            // IntButton
            // 
            this.IntButton.Location = new System.Drawing.Point(129, 21);
            this.IntButton.Margin = new System.Windows.Forms.Padding(4);
            this.IntButton.Name = "IntButton";
            this.IntButton.Size = new System.Drawing.Size(100, 28);
            this.IntButton.TabIndex = 2;
            this.IntButton.Text = "Int demo";
            this.IntButton.UseVisualStyleBackColor = true;
            this.IntButton.Click += new System.EventHandler(this.IntButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(236, 25);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 276);
            this.Controls.Add(this.FromForm2TextBox);
            this.Controls.Add(this.SendButton1);
            this.Controls.Add(this.SimpleMessageToChildTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Move += new System.EventHandler(this.Form1_Move);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button IntButton;
    }
}

