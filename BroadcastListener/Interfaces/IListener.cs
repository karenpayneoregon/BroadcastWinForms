using System.Windows.Forms;

namespace BroadcastListener.Interfaces
{
    public interface IMessageListener1 
    {
        void OnListen(string message, Form form);
        void OnListen(int value, Form form);
    }
}
