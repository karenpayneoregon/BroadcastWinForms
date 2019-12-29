using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BroadcastListener_2.Controls
{
    public class ObservableButton : Button, IObservable<string>
    {
        private readonly List<IObserver<string>> _observers;

        public ObservableButton()
        {
            _observers = new List<IObserver<string>>();
        }

        IDisposable IObservable<string>.Subscribe(IObserver<string> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }

            return new Unsubscriber(_observers, observer);
        }

        public void Notify(string Message)
        {

            foreach (IObserver<string> observer in _observers)
            {
                observer.OnNext(Message);
            }

        }
        /// <summary>
        /// Clear TextBox controls
        /// </summary>
        public void Reset()
        {

            foreach (IObserver<string> observer in _observers)
            {
                observer.OnNext("");
            }

        }
        private class Unsubscriber : IDisposable
        {
            private List<IObserver<string>> observers;
            private IObserver<string> observer;

            public Unsubscriber(List<IObserver<string>> observers, IObserver<string> observer)
            {
                this.observers = observers;
                this.observer = observer;
            }

            public void Dispose()
            {
                if (observer != null && observers.Contains(observer))
                {
                    observers.Remove(observer);
                }
            }

        }
    }
}