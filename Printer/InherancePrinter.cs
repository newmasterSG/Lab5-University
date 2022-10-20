using System;
using System.Collections.Generic;
using System.Text;

namespace Printer
{
    internal class InherancePrinter:Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
