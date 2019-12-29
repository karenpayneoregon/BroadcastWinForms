using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Forms;
using BroadcastListener_2.Interfaces;

namespace BroadcastListener_2.Classes
{
    public class Broadcaster
    {
        private readonly Collection<IMessageListener> _listeners = new Collection<IMessageListener>(); 

        /// <summary>
        /// Send message
        /// </summary>
        /// <param name="Message">Message</param>
        /// <remarks></remarks>
        [DebuggerStepThrough()]
        public void Broadcast(Person person, Form sender)
        {
            foreach (IMessageListener listener in _listeners)
            {
                listener.OnListen(person,sender);
            }
        }
       
        /// <summary>
        /// Add a Listener to the Collection of Listeners
        /// </summary>
        /// <param name="Listener"></param>
        public void AddListener(IMessageListener Listener)
        {
            _listeners.Add(Listener);
        }
        /// <summary>
        /// Remove a Listener from the collection
        /// </summary>
        /// <param name="Listener"></param>
        public void RemoveListener(IMessageListener Listener)
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
