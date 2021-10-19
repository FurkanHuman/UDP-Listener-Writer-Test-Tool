using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPListener
{
    public class UdpSocketListener
    {
        public static void Receiver(int PortNumber)
        {
            using UdpClient udpClient = new(PortNumber);
            IPEndPoint iPEndPoint = new(IPAddress.Any, PortNumber);
            while (true)
            {
                byte[] receivedData = udpClient.Receive(ref iPEndPoint);
                Console.WriteLine(Encoding.ASCII.GetString(receivedData));
            }
        }
    }
}
