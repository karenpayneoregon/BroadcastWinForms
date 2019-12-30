using System;
using System.Windows.Forms;

namespace BroadcastListener.Interfaces
{
    public interface IMessageListener1 
    {
        void OnListen(string Message, Form Type);
    }
}
