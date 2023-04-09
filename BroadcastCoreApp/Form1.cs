using BroadcastCoreApp.Classes;
using WinFormLibrary.Interfaces;

namespace BroadcastCoreApp;

[SuppressMessage("ReSharper", "PossibleMultipleEnumeration")]
public partial class Form1 : Form, IMessageListener1
{
    public Form1()
    {
        InitializeComponent();

        Closing += Form1_Closing!;
        Move += Form1_Move;
        Dispatcher().AddListener(this);

    }
    
    public void OnListen(string message, Form form)
    {
        
        switch (message)
        {
            case "clear":
                listBox1.Items.Clear();
                break;
            case "done":
                // select current month
                listBox1.SelectedIndex = listBox1.FindString(
                    DateTime.Now.ToString("MMMM"));
                Debug.WriteLine($"Finished from {form.Text}");
                break;
            default:
                listBox1.Items.Add(message);
                break;
        }
    }

    public void OnListen(int value, Form form)
    {
        if (form is Form1)
        {
            pictureBox1.Image = value > 10 ? 
                Properties.Resources.red : 
                Properties.Resources.green;
        }
    }

    public void OnListen(object sender, Form form)
    {
        // not used
    }

    private void BogusButton_Click(object sender, EventArgs e)
    {
        Dispatcher()
            .Broadcast(BogusOperations.People()
                .FirstOrDefault()!, this);
        
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
    {
        Dispatcher()
            .Broadcast((int)numericUpDown1.Value, this);
    }

    private void Form1_Closing(object sender, CancelEventArgs e)
    {
        Dispatcher().RemoveListener(this);
        
    }

    private void ShowForm2Button_Click(object sender, EventArgs e)
    {
        var childForm1 = new Form2
        {
            Top = Top, 
            Left = (Left + Width) + 20, 
            Tag = "Right", 
            Text = "Right"
        };
        childForm1.Show();

        var childForm2 = new Form2
        {
            Top = Top, 
            Left = (Left - Width) + 140, 
            Tag = "Left", 
            Text = "Left"
        };

        childForm2.Show();
    }
    private void Form1_Move(object sender, EventArgs e)
    {
        var childForms = Application.OpenForms.Cast<Form>()
            .Where(form => form.Name == nameof(Form2));

        if (!childForms.Any()) return;
        foreach (var currentChildForm in childForms)
        {
            currentChildForm.Top = Top;

            currentChildForm.Left = currentChildForm.Tag!.ToString() == "Left" ?
                (Left - Width) + 140 :
                (Left + Width) + 20;
        }
    }
}
