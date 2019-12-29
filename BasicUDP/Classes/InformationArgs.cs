using System;

namespace BasicUDP.Classes
{
    public class InformationArgs : EventArgs
    {
        protected string Value;
        public InformationArgs(string sender) => Value = sender;
        public string Text => Value;
    }
}