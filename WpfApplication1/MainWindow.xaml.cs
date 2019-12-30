using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApplication1.Classes;
using WpfApplication1.Interfaces;
using static WpfApplication1.Classes.Factory;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMessageListener
    {
        private Person _person = new Person() {FirstName = "Sue", LastName = "White", Id = -1};
        public MainWindow()
        {
            InitializeComponent();

            DataContext = _person;
            Broadcaster().AddListener(this);
        }

        public void OnListen(Person person, Window form)
        {
            if (form is ChildWindow1)
            {
                DataContext = person;
            }
        }

        private void ShowChildWindow_Click(object sender, RoutedEventArgs e)
        {
            
            var form = new ChildWindow1() {Owner = this};
            Broadcaster().Broadcast(new Person()
            {
                FirstName = ((Person)DataContext).FirstName,
                LastName = ((Person)DataContext).LastName,
                Id = -1
            }, this);

            form.ShowDialog();
        }
    }
}
