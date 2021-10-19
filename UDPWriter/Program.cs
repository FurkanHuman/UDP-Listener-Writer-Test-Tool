using System;

namespace UDPWriter
{
    class Program
    {
        static void Main()
        {
            Console.Write("UDP Adresini girin: ");
            string address = Console.ReadLine();
            Console.Write("Port  girin: ");
            UInt16 port = UInt16.Parse(Console.ReadLine());

            while (true)
            {
                String message = Console.ReadLine();
                UDPListener.UdpSocketWriter.Sender(address, port, message);
            }
        }
    }
}
