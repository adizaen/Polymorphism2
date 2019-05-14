using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPolymorphism2
{
    class PrinterWindows
    {
        public string Name { get; set; }

        public virtual void Show()
        {
            Console.WriteLine("Printer show name");
        }

        public virtual void Print()
        {
            Console.WriteLine("Printer print file");
        }
    }
}
