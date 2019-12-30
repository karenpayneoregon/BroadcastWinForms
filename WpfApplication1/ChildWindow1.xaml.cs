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
using Broadcaster = WpfApplication1.Classes.Broadcaster;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for ChildWindow1.xaml
    /// </summary>
    public partial class ChildWindow1 : Window, IMessageListener
    {
        public ChildWindow1()
        {
            InitializeComponent();
            Broadcaster().AddListener(this);
        }

        public void OnListen(Person person, Window form)
        {
            if (form is MainWindow)
            {
                DataContext = person;
            }

        }

        private bool _shown;

        protected override void OnContentRendered(EventArgs e)
        {
            base.OnContentRendered(e);

            _shown = true;

            Top += 200;
        }

        private void BroadCast_Click(object sender, RoutedEventArgs e)
        {
            Broadcaster().Broadcast(DataContext as Person,this );
        }
    }
}
