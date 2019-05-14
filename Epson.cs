using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism2
{
    class Epson : PrinterWindows
    {
        public override void Print()
        {
            Console.WriteLine("Epson printer printing ....");
        }

        public override void Show()
        {
            Console.WriteLine("LaserJet display dimension : 10*11");
        }
    }
}
