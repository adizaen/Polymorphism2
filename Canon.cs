using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism2
{
    class Canon : PrinterWindows
    {
        public override void Print()
        {
            Console.WriteLine("Canon printer printing ....");
        }

        public override void Show()
        {
            Console.WriteLine("LaserJet display dimension : 9.5*12");
        }
    }
}
