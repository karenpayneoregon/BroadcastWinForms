using System;
using System.Windows.Forms;

namespace BroadcastListener_2.Controls
{
    public class ObserverTextBox : TextBox, IObserver<string>
    {
        private IDisposable _unsubscriber;

        void IObserver<string>.OnCompleted()
        {
        }

        void IObserver<string>.OnError(Exception error)
        {

        }
        void IObserver<string>.OnNext(string value)
        {
            Text = value;
            Refresh();
        }

        public virtual void Subscribe(IObservable<string> provider)
        {
            if (provider != null)
            {
                _unsubscriber = provider.Subscribe(this);
            }
        }
        public virtual void Unsubscribe()
        {
            _unsubscriber.Dispose();
        }
    }
}
