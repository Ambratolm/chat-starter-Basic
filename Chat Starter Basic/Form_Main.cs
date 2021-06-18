using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ChatStarterBasic
{
    public partial class Form_Main : Form
    {
        private Socket _socket;
        private EndPoint _localEndPoint, _remoteEndPoint;
        private IPAddress _localIP, _remoteIP;
        private int _localPort, _remotePort;

        public Form_Main()
        {
            InitializeComponent();
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            _socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            _localIP = IPAddress.Parse(GetLocalIP());
            _remoteIP = IPAddress.Parse(GetLocalIP());
            _localPort = 80;
            _remotePort = 80;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text += " - " + GetLocalIP();
            button_send.Enabled = false;
            textBox_message.Focus(); textBox_message.Select();
            button_connect.PerformClick();
        }

        public string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        public void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = _socket.EndReceiveFrom(aResult, ref _remoteEndPoint);
                if (size > 0)
                {
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);
                    listBox_conversation.Items.Add(_remoteIP + " : " + receivedMessage);
                }
                byte[] buffer = new byte[1500];
                _socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref _remoteEndPoint,
                    new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            try
            {
                ASCIIEncoding eEncoding = new ASCIIEncoding();
                string sentMessage = textBox_message.Text;
                byte[] sentData = new byte[1500];
                sentData = eEncoding.GetBytes(sentMessage);
                _socket.Send(sentData);
                listBox_conversation.Items.Add("ME : " + sentMessage);
                textBox_message.Clear();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            try
            {
                _localEndPoint = new IPEndPoint(_localIP, _localPort);
                _socket.Bind(_localEndPoint);
                _remoteEndPoint = new IPEndPoint(_remoteIP, _remotePort);
                _socket.Connect(_remoteEndPoint);
                byte[] buffer = new byte[1500];
                _socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref _remoteEndPoint,
                    new AsyncCallback(MessageCallBack), buffer);
                button_connect.Enabled = false;
                button_send.Enabled = true;
                textBox_message.Focus();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
