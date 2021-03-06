﻿using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace BasicUDP.Classes
{
    public class BasicUDPSocket
    {
        private readonly Socket _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

        private const int BufSize = 8 * 1024;
        private State _state = new State();
        private EndPoint _epFrom = new IPEndPoint(IPAddress.Any, 0);
        private AsyncCallback _recv = null;

        public class State
        {
            public byte[] buffer = new byte[BufSize];
        }

        public void Server(string address, int port)
        {
            _socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.ReuseAddress, true);
            _socket.Bind(new IPEndPoint(IPAddress.Parse(address), port));
            Receive();
        }

        public void Client(string address, int port)
        {
            _socket.Connect(IPAddress.Parse(address), port);
            Receive();
        }

        public void Send(string text)
        {
            byte[] data = Encoding.ASCII.GetBytes(text);

            _socket.BeginSend(data, 0, data.Length, SocketFlags.None, (ar) =>
            {
                var so = (State)ar.AsyncState;
                int bytes = _socket.EndSend(ar);

                //Console.WriteLine($"SEND: {bytes}, {1} {text}");

            }, _state);
        }

        public void Receive()
        {

            _socket.BeginReceiveFrom(_state.buffer, 0, BufSize, SocketFlags.None, ref _epFrom, _recv = (ar) =>
            {
                var so = (State)ar.AsyncState;
                int bytes = _socket.EndReceiveFrom(ar, ref _epFrom);
                _socket.BeginReceiveFrom(so.buffer, 0, BufSize, SocketFlags.None, ref _epFrom, _recv, so);
                OnMessageRecievedHandler?.Invoke(this, new InformationArgs(Encoding.ASCII.GetString(so.buffer, 0, bytes)));
            }, _state);

        }

        public delegate void InformationHandler(object sender, InformationArgs myArgs);

        public event InformationHandler OnMessageRecievedHandler;
    }
}