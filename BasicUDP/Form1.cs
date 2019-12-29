using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicUDP.Classes;

namespace BasicUDP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            _socket = new UdpClient(5394);
        }

        private UdpClient _socket = new UdpClient();

        void OnUdpData(IAsyncResult result)
        {
            // this is what had been passed into BeginReceive as the second parameter:
            var socket = result.AsyncState as UdpClient;
            // points towards whoever had sent the message:
            var source = new IPEndPoint(0, 0);
            // get the actual message and fill out the source:
            byte[] message = socket.EndReceive(result, ref source);
            var receivedText = Encoding.ASCII.GetString(message);

            listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add(receivedText)));
            // schedule the next receive operation once reading is done:
            socket.BeginReceive(OnUdpData, socket);
        }

        private void TalkToSelfButton_Click(object sender, EventArgs e)
        {
            // schedule the first receive operation:
            _socket.BeginReceive(OnUdpData, _socket);

            // sending data (for the sake of simplicity, back to ourselves):
            var target = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5394);

            var messageList = new List<string>()
            {
                "First message",
                "Second message",
                "This is the last message"
            };


            for (var index = 0; index < messageList.Count; index++)
            {
                _socket.Send(Encoding.ASCII.GetBytes(messageList[index]), messageList[index].Length, target);
            }
        }


        private Form2 _childForm2;
        private void ShowForm2Button_Click(object sender, EventArgs e)
        {
            _childForm2 = new Form2 { Top = Top, Left = (Left + Width) + 20 };
            _childForm2.Show();
            ShowForm2Button.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (Application.OpenForms.Cast<Form>().Any(form => form.Name == "Form2"))
            {
                if (!string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    var clientSocket = new BasicUDPSocket();
                    clientSocket.Client("127.0.0.1", 27000);
                    clientSocket.Send(textBox1.Text);
                }
                else
                {
                    MessageBox.Show("Please enter some text");
                    ActiveControl = textBox1;
                }
            }
            else
            {
                MessageBox.Show("Child form must be shown");
            }
        }
    }
}
