using System;
using TestProj.Devices.Interfaces;

namespace TestProj.Devices
{
    class Scanner : Device, IScanner
    {
        public override void ProcessDoc()
        {
            Console.WriteLine("Scanner processing...");
        }

        public string Scan()
        {
            return "Scaning...";
        }
    }
}
