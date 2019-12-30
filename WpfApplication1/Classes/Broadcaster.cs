using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows;
using WpfApplication1.Interfaces;

namespace WpfApplication1.Classes
{
    public class Broadcaster
    {
        private readonly Collection<IMessageListener> _listeners = new Collection<IMessageListener>(); 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="person">Valid Person</param>
        /// <param name="sender">Window in project to broadcast from</param>
        public void Broadcast(Person person, Window sender)
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
