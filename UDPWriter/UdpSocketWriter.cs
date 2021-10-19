using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UDPListener
{
   public class UdpSocketWriter
    {
        public static void Sender(string ipAddress, UInt16 portNumber, string sendMessage)
        {
            using UdpClient udpClient = new(ipAddress, portNumber);
            byte[] sendBytes = Encoding.ASCII.GetBytes(sendMessage);

            try
            {
                udpClient.Send(sendBytes, sendBytes.Length);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
