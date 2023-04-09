using System.Collections.ObjectModel;
using System.Diagnostics;
using WinFormLibrary.Interfaces;

namespace WinFormLibrary.Classes;

public class Dispatcher
{
    private readonly Collection<IMessageListener1> _listeners = new();

    /// <summary>
    /// Send message
    /// </summary>
    /// <param name="message">Message</param>
    /// <param name="sender"></param>
    /// <remarks></remarks>
    [DebuggerStepThrough()]
    public void Broadcast(string message, Form sender)
    {
        foreach (IMessageListener1 listener in _listeners)
        {
            listener.OnListen(message, sender);
        }
    }

    /// <summary>
    /// Send int
    /// </summary>
    /// <param name="value">value to sender</param>
    /// <param name="sender">form which sent the value</param>
    [DebuggerStepThrough()]
    public void Broadcast(int value, Form sender)
    {
        foreach (IMessageListener1 listener in _listeners)
        {
            listener.OnListen(value, sender);
        }
    }

    /// <summary>
    /// Send object
    /// </summary>
    /// <param name="value">value to sender</param>
    /// <param name="sender">form which sent the value</param>
    [DebuggerStepThrough()]
    public void Broadcast(object value, Form sender)
    {
        foreach (IMessageListener1 listener in _listeners)
        {
            listener.OnListen(value, sender);
        }
    }

    /// <summary>
    /// Add a Listener to the Collection of Listeners
    /// </summary>
    /// <param name="listener"></param>
    public void AddListener(IMessageListener1 listener)
    {
        _listeners.Add(listener);
    }
    /// <summary>
    /// Remove a Listener from the collection
    /// </summary>
    /// <param name="listener"></param>
    public void RemoveListener(IMessageListener1 listener)
    {

        for (int index = 0; index < _listeners.Count; index++)
        {
            if ( _listeners[index].Equals(listener) )
            {
                _listeners.Remove(_listeners[index]);
            }
        }
    }
}