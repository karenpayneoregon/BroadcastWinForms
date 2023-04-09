using System.ComponentModel;
using WinFormLibrary.Interfaces;
using static WinFormLibrary.Classes.Factory;
using System.Globalization;
using BroadcastCoreApp.Models;

namespace BroadcastCoreApp;
public partial class Form2 : Form, IMessageListener1
{
    public Form2()
    {
        InitializeComponent();
        Closing += Form1_Closing!;
        Broadcaster().AddListener(this);
    }

    private void Form1_Closing(object sender, CancelEventArgs e)
    {
        Broadcaster().RemoveListener(this);

    }
    public void OnListen(string message, Form form)
    {
        // not used
    }

    public void OnListen(int value, Form form)
    {
        if (form is Form1)
        {
            pictureBox1.Image = value > 10 ? 
                Properties.Resources.red : Properties.Resources.green;
        }
    }

    public void OnListen(object sender, Form form)
    {
        if (sender is Person person)
        {
            MessageBox.Show(
                $"""
                        {Text}
                        {person.FirstName} {person.LastName}
                     """);
        }
    }

    private void SendToMainFormButton_Click(object sender, EventArgs e)
    {
        Broadcaster().Broadcast("clear", this);
        var months = DateTimeFormatInfo.CurrentInfo.MonthNames[..^1].ToList();

        foreach (var month in months)
        {
            Broadcaster().Broadcast(month, this);
        }

        Broadcaster().Broadcast("done", this);
    }
}
