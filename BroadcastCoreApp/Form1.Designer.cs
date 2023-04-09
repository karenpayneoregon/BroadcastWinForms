namespace BroadcastCoreApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShowForm2Button = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BogusButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BroadcastCoreApp.Properties.Resources.green;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ShowForm2Button
            // 
            this.ShowForm2Button.Location = new System.Drawing.Point(12, 235);
            this.ShowForm2Button.Name = "ShowForm2Button";
            this.ShowForm2Button.Size = new System.Drawing.Size(148, 29);
            this.ShowForm2Button.TabIndex = 1;
            this.ShowForm2Button.Text = "Show child form";
            this.ShowForm2Button.UseVisualStyleBackColor = true;
            this.ShowForm2Button.Click += new System.EventHandler(this.ShowForm2Button_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(190, 237);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(597, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 244);
            this.listBox1.TabIndex = 3;
            // 
            // BogusButton
            // 
            this.BogusButton.Location = new System.Drawing.Point(12, 186);
            this.BogusButton.Name = "BogusButton";
            this.BogusButton.Size = new System.Drawing.Size(148, 29);
            this.BogusButton.TabIndex = 4;
            this.BogusButton.Text = "Send person";
            this.BogusButton.UseVisualStyleBackColor = true;
            this.BogusButton.Click += new System.EventHandler(this.BogusButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 276);
            this.Controls.Add(this.BogusButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ShowForm2Button);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Broadcast";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private PictureBox pictureBox1;
    private Button ShowForm2Button;
    private NumericUpDown numericUpDown1;
    private ListBox listBox1;
    private Button BogusButton;
}
