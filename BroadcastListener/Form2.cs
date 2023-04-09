using System;
using System.ComponentModel;
using System.Windows.Forms;
using BroadcastListener.Interfaces;
using static BroadcastListener.Classes.Factory;

namespace BroadcastListener
{
    public partial class Form2 : Form, IMessageListener1
    {
        public Form2()
        {
            InitializeComponent();

            Broadcaster().AddListener(this);

            Closing += Form2_Closing;
        }
        /// <summary>
        /// Listener here only reacts to Form1 messages
        /// </summary>
        /// <param name="message">Incoming message</param>
        /// <param name="sender">Calling form</param>
        public void OnListen(string message, Form sender)
        {
            if (sender is Form1)
            {
                StringFromForm1TextBox.Text = message;
            }
        }

        public void OnListen(int value, Form form)
        {
            pictureBox1.Visible = value > 10;
        }

        private void SendToForm1TextBox_Click(object sender, EventArgs e)
        {
            Broadcaster().Broadcast($"{StringToForm1TextBox.Text} - {DateTime.Now.ToShortTimeString()}", this);
        }
        private void Form2_Closing(object sender, CancelEventArgs e)
        {
            Broadcaster().RemoveListener(this);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
