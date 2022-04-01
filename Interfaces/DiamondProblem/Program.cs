using System;
using TestProj.Devices;

namespace TestProj
{
    class Program 
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { SerialNumber = 5117 };
            Scanner s = new Scanner() { SerialNumber = 1251 };
            ComboDevice cd = new ComboDevice() { SerialNumber = 6489 };

            p.ProcessDoc();
            Console.WriteLine(p.Print());

            Console.WriteLine("------------------------");

            s.ProcessDoc();
            Console.WriteLine(s.Scan());

            Console.WriteLine("------------------------");
            cd.ProcessDoc();
            Console.WriteLine(cd.Print()); 
            Console.WriteLine(cd.Scan()); 
        }
    }
}

