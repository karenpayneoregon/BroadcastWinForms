using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicUDP.Classes;

namespace BasicUDP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private BasicUDPSocket _socket = new BasicUDPSocket();
        private void Form2_Load(object sender, EventArgs e)
        {
            _socket = new BasicUDPSocket();
            _socket.OnMessageRecievedHandler += _socket_OnListBoxClickHandler;
            _socket.Server("127.0.0.1", 27000);
            
        }

        private void _socket_OnListBoxClickHandler(object sender, InformationArgs myArgs)
        {

            try
            {

                //textBox1.Invoke((MethodInvoker)(() => textBox1.Text = myArgs.Text));
                textBox1.SafeInvoke(() => { textBox1.Text = myArgs.Text; });
            }
            catch (Exception ex)
            {
            }
        }

    }
}
