using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.ComponentModel;

namespace ChatStarterBasic
{
    public class ChatSession
    {
        public Socket Socket { get; set; }
        public IPEndPoint LocalEP { get; set; }
        public IPEndPoint RemoteEP { get; set; }
        public BackgroundWorker BackgroundWorker { get; set; }

        public event MessageReceivedEventHandler MessageReceived;

        public ChatSession(IPEndPoint localEP = null, IPEndPoint remoteEP = null)
        {
            this.Socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            this.Socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            if (localEP == null) localEP = new IPEndPoint(Network.GetLocalIP(), 80);
            if (remoteEP == null) remoteEP = new IPEndPoint(Network.GetLocalIP(), 80);
            this.LocalEP = localEP;
            this.RemoteEP = remoteEP;
            this.BackgroundWorker = new BackgroundWorker();
            SetupBackgroundWorker();
        }

        public void ConnectAsync()
        {
            if (!BackgroundWorker.IsBusy) BackgroundWorker.RunWorkerAsync();
        }

        private string Connect()
        {
            if (!Socket.IsBound) Socket.Bind(LocalEP);
            if (!Socket.Connected) Socket.Connect(RemoteEP);
            EndPoint remoteEP = this.RemoteEP;
            byte[] buffer = new byte[1500];
            int size = Socket.ReceiveFrom(
                buffer: buffer,
                offset: 0,
                size: buffer.Length,
                socketFlags: SocketFlags.None,
                remoteEP: ref remoteEP
            );
            if (size > 0)
            {
                return new ASCIIEncoding().GetString(buffer);
            }
            return null;
        }


        public void Disconnect()
        {
            if (Socket.Connected) Socket.Disconnect(true);
            if (BackgroundWorker.IsBusy) BackgroundWorker.CancelAsync();
        }

        public void SendMessage(string message)
        {
            Socket.Send(new ASCIIEncoding().GetBytes(message));
        }

        private void SetupBackgroundWorker()
        {
            this.BackgroundWorker.WorkerSupportsCancellation = true;
            this.BackgroundWorker.DoWork += (s, e) =>
            {
                e.Result = Connect();
            };
            this.BackgroundWorker.RunWorkerCompleted += (s, e) =>
            {
                string message = e.Result as string;
                if (message != null)
                {
                    OnMessageReceived(new MessageReceivedEventArgs(message, this.RemoteEP.Address));
                }
                ConnectAsync();
            };
        }

        private void OnMessageReceived(MessageReceivedEventArgs e)
        {
            if (MessageReceived != null)
            {
                this.MessageReceived(this, e);
            }
        }
    }
}
