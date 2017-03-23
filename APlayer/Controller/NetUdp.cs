using System;
using System.Collections.Generic;
using System.Text;
using WinSock;

namespace APlayer.Controller
{
    public class NetUdp : INetUdp
    {

        private Action<string> msgHandler;
        private UdpServer udp = new UdpServer();

        public void Close()
        {
            udp.DataReceived -= Udp_DataReceived;
            udp?.Close();
        }

        public void Listen(int port)
        {
            udp.Listen(port);
            udp.DataReceived += Udp_DataReceived;
        }

        private void Udp_DataReceived(object sender, DataReceivedEventArgs e)
        {
            msgHandler?.Invoke(e.RecString);
        }

        public void UdpProcess(Action<string> action)
        {
            msgHandler = action;
        }
    }
}
