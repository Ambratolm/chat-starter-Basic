using System.Net;
using System.Net.Sockets;

namespace ChatStarterBasic
{
    static class Network
    {
        public static IPAddress GetLocalIP()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip;
                }
            }
            return IPAddress.Parse("127.0.0.1");
        }
    }
}
