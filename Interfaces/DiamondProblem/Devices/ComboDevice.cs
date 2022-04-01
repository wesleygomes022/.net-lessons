using System;
using TestProj.Devices.Interfaces;

namespace TestProj.Devices
{
    class ComboDevice : Device, IPrinter, IScanner
    {
        public override void ProcessDoc()
        {
            Console.WriteLine("ComboDevice processing...");
        }
        public string Print()
        {
            return "Combodevice print";
        }

        public string Scan()
        {
            return "ComboDevice scan result";
        }
    }
}
