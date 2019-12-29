﻿using System;
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
    public partial class Form1 : Form , IMessageListener1
    {
        public Form1()
        {
            InitializeComponent();
            Broadcaster().AddListener(this);

            Closing += Form1_Closing;
            Shown += Form1_Shown;
            
        }

        /// <summary>
        /// Listener here only reacts to Form2 messages
        /// </summary>
        /// <param name="Message">Incoming message</param>
        /// <param name="sender">Calling form</param>
        public void OnListen(string Message, Form sender)
        {

            if (sender is Form2)
            {
                FromForm2TextBox.Text = Message;
            }

        }
        /// <summary>
        /// Send simple text message to all listeners
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SendButton1_Click(object sender, EventArgs e)
        {
            Broadcaster().Broadcast(SimpleMessageToChildTextBox.Text, this);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            SimpleMessageToChildTextBox.Text = $"From {Name} at {DateTime.Now:F}";
        }

        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            Broadcaster().RemoveListener(this);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Show two instances of Form2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowChildFormButton_Click(object sender, EventArgs e)
        {
            var childForm1 = new Form2 {Top = Top, Left = (Left + Width) + 20, Tag = "Right"};
            childForm1.Show();

            var childForm2 = new Form2 { Top = Top, Left = (Left - Width) + 120, Tag = "Left"};
            childForm2.Show();

        }

        /// <summary>
        /// Move any Form2 instance in sync with this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Move(object sender, EventArgs e)
        {

            var childForms = Application.OpenForms.Cast<Form>()
                .Where(form => form.Name == "Form2");

            if (childForms.Any())
            {
                foreach (var currentChildForm in childForms)
                {
                    currentChildForm.Top = Top;

                    currentChildForm.Left = currentChildForm.Tag.ToString() == "Left" ?
                        (Left - Width) + 120:
                        (Left + Width) + 20;
                }
            }
        }

    }
}