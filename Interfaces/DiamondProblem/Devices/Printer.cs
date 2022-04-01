using System;
using TestProj.Devices.Interfaces;

namespace TestProj.Devices
{
    class Printer : Device, IPrinter
    {
        public override void ProcessDoc()
        {
            Console.WriteLine("Printer processing...");
        }

        public string Print()
        {
            return "Priting...";
        }
    }
}
