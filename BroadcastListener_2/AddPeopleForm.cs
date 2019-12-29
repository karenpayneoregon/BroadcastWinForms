using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BroadcastListener_2.Classes;
using BroadcastListener_2.Controls;
using BroadcastListener_2.Interfaces;
using static BroadcastListener_2.Classes.Factory;

namespace BroadcastListener_2
{
    public partial class AddPeopleForm : Form, IMessageListener
    {
        public AddPeopleForm()
        {
            InitializeComponent();
            Broadcaster().AddListener(this);
            Closing += AddPeopleForm_Closing;
        }

        private void AddPeopleForm_Closing(object sender, CancelEventArgs e)
        {
            Broadcaster().RemoveListener(this);
            FirstNameTextBox.Unsubscribe();
            LastNameTextBox.Unsubscribe();
        }
        /// <summary>
        /// Indicate that the two custom TextBox controls
        /// are subscribers to the custom button which when
        /// the button invokes Reset method those TextBox controls
        /// will be cleared of current data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPeopleForm_Load(object sender, EventArgs e)
        {
            FirstNameTextBox.Subscribe(AddButton);
            LastNameTextBox.Subscribe(AddButton);

            Controls.OfType<ObserverTextBox>().ToList()
                .ForEach(otb => otb.KeyDown += shared_KeyDown);

        }
        /// <summary>
        /// Move to next control when pressing ENTER key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shared_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                SelectNextControl((Control)sender, true, true, true, true);
                e.SuppressKeyPress = true;
            }
        }
        /// <summary>
        /// Add person if does not exists in calling form DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {

            if (Controls.OfType<TextBox>().Any(tb => string.IsNullOrWhiteSpace(tb.Text)))
            {
                MessageBox.Show("First and last name required");
            }
            else
            {
                Broadcaster().Broadcast(new Person()
                {
                    FirstName = FirstNameTextBox.Text,
                    LastName = LastNameTextBox.Text,
                    Id = -1
                }, this);

                AddButton.Reset();
                ActiveControl = FirstNameTextBox;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="person"></param>
        /// <param name="form"></param>
        public void OnListen(Person person, Form form)
        {
            if (form is Form1)
            {
                FirstNameTextBox.Text = person.FirstName;
                LastNameTextBox.Text = person.LastName;
            }
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
