﻿using System;

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
            Console.Clear();
            while (true)
            {
                String message = Console.ReadLine();
                Console.WriteLine("Time: " + DateTime.Now + ":" + DateTime.Now.Millisecond +" | "+ message);
                UDPListener.UdpSocketWriter.Sender(address, port, message);
            }
        }
    }
}
