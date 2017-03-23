using System;
using System.Collections.Generic;
using System.Text;

namespace APlayer.Controller
{
    interface INetUdp
    {
        void Listen(int port);
        void Close();
        void UdpProcess(Action<string> action);
    }
}
