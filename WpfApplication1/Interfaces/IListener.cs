using System.Windows;
using WpfApplication1.Classes;

namespace WpfApplication1.Interfaces
{
    public interface IMessageListener
    {
        void OnListen(Person person, Window form);
    }
}
