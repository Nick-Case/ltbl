﻿using System;
using System.Reflection;

namespace Base
{
    public class Button : IDevice
    {
        private string _messageText;

        public string Name { get; set; }

        public string Address { get; set; }

        public int Port { get; set; }

        public NetworkType Type { get; set; }

        public IMessage Message { get; set; }

        public bool Ack { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Button()
        {
            
        }

        public Button(string _name, string _address, string _message, int _port, string _type, bool _ack)
        {
            Name = _name;
            Address = _address;
            _messageText = _message;
            Port = _port;
            Type = (NetworkType)Enum.Parse(typeof(NetworkType), _type);
            Ack = _ack;
        }

        public string Invoke()
        {
            switch (Type)
            {
                case NetworkType.UDP:
                    Message = new UdpMessage
                    {
                        Address = Address,
                        Port = Port,
                        Message = _messageText,
                        Ack = Ack
                    };
                    return Message.Invoke().Result;
                    break;
                case NetworkType.TCP:
                    Message = new TcpMessage()
                    {
                        Address = Address,
                        Port = Port,
                        Message = _messageText,
                        Ack = Ack
                    };
                    return Message.Invoke().Result;
                    break;
            }
            return null;
        }
    }
}
