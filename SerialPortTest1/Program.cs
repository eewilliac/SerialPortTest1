using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;


namespace SerialPortTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialPort port = new SerialPort("COM3", 9600, Parity.None, 8, StopBits.One);
            port.DataReceived += Port_DataReceived;
            port.Open();
            port.Write("10101010111010101010");
            Console.WriteLine("Done!");
            Console.ReadKey();
        }

        private static void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Console.WriteLine("PortDiagnostics");
        }
    }
}
