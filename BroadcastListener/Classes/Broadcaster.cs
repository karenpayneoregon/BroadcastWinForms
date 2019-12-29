using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BroadcastListener.Interfaces;

namespace BroadcastListener.Classes
{
    public class Broadcaster
    {
        private readonly Collection<IMessageListener1> _listeners = new Collection<IMessageListener1>(); 

        /// <summary>
        /// Send message
        /// </summary>
        /// <param name="Message">Message</param>
        /// <remarks></remarks>
        [DebuggerStepThrough()]
        public void Broadcast(string Message, Form sender)
        {
            foreach (IMessageListener1 listener in _listeners)
            {
                listener.OnListen(Message, sender);
            }
        }
       
        /// <summary>
        /// Add a Listener to the Collection of Listeners
        /// </summary>
        /// <param name="Listener"></param>
        public void AddListener(IMessageListener1 Listener)
        {
            _listeners.Add(Listener);
        }
        /// <summary>
        /// Remove a Listener from the collection
        /// </summary>
        /// <param name="Listener"></param>
        public void RemoveListener(IMessageListener1 Listener)
        {

            for (int index = 0; index < _listeners.Count; index++)
            {
                if ( _listeners[index].Equals(Listener) )
                {
                    _listeners.Remove(_listeners[index]);
                }
            }
        }
    }
}
