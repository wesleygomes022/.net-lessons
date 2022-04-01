using System;

namespace TestProj.Devices
{
    abstract class Device
    {
        public int SerialNumber { get; set; }
       
        public abstract void ProcessDoc();
    }
}
