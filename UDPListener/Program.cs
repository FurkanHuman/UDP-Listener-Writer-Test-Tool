using System;

namespace UDPListener
{
   class Program
    {
        static void Main()
        {
            Console.Write("Dinlenecek portu girin: ");
            UInt16 port = UInt16.Parse( Console.ReadLine());
            Console.Clear();
            UdpSocketListener.Receiver(port);            
        }
    }
}
