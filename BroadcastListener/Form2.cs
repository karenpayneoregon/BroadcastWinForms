using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        /// <param name="Message">Incoming message</param>
        /// <param name="sender">Calling form</param>
        public void OnListen(string Message, Form sender)
        {
            if (sender is Form1)
            {
                StringFromForm1TextBox.Text = Message;
            }
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
