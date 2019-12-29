using System.Windows.Forms;
using BroadcastListener_2.Classes;

namespace BroadcastListener_2.Interfaces
{
    public interface IMessageListener
    {
        void OnListen(Person person, Form form);
    }
}
