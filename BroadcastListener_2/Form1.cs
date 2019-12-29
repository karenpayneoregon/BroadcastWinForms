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
using BroadcastListener_2.Interfaces;
using static BroadcastListener_2.Classes.Factory;

namespace BroadcastListener_2
{
    public partial class Form1 : Form, IMessageListener
    {
        private BindingSource _bindingSource = new BindingSource();
        private List<Person> _personsList = new List<Person>();
        public Form1()
        {
            InitializeComponent();

            Broadcaster().AddListener(this);

            Closing += Form1_Closing;
        }

        private void Form1_Closing(object sender, CancelEventArgs e)
        {
            Broadcaster().RemoveListener(this);
        }

        public void OnListen(Person person, Form form)
        {
            if (_personsList.FirstOrDefault(p => p.FirstName == person.FirstName && p.LastName == person.LastName) == null)
            {
                ((List<Person>)_bindingSource.DataSource).Add(person);
                _bindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Dup");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            _bindingSource.DataSource = _personsList;
            dataGridView1.DataSource = _bindingSource;
        }

        private void AddPeopleButton_Click(object sender, EventArgs e)
        {
            var form = new AddPeopleForm();
            form.ShowDialog();
        }
    }
}
