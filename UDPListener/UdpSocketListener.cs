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

                Console.WriteLine("Time: " + DateTime.Now + ":" + DateTime.Now.Millisecond + " | Hex: " + BitConverter.ToString(receivedData) + " | ASCII: " +
                Encoding.ASCII.GetString(receivedData) + " | UTF8: " + Encoding.UTF8.GetString(receivedData) + " | UTF32: " +
                Encoding.UTF32.GetString(receivedData) + " | Unicode: " + Encoding.Unicode.GetString(receivedData) + " | Latin1: " +
                Encoding.Latin1.GetString(receivedData));

            }
        }
    }
}
