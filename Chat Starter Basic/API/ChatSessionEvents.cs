using System;
using System.Net;

namespace ChatStarterBasic
{
    public delegate void MessageReceivedEventHandler(object sender, MessageReceivedEventArgs e);

    public class MessageReceivedEventArgs : EventArgs
    {
        public string Message { get; private set; }
        public DateTime ReceivedAt { get; private set; }
        public IPAddress SenderIP { get; private set; }

        public MessageReceivedEventArgs(string message, IPAddress senderIP = null)
        {
            this.Message = message;
            this.ReceivedAt = DateTime.Now;
            this.SenderIP = senderIP;
        }

        public MessageReceivedEventArgs(string message, DateTime receivedAt, IPAddress senderIP = null)
        {
            this.Message = message;
            this.ReceivedAt = receivedAt;
            this.SenderIP = senderIP;
        }
    }
}
