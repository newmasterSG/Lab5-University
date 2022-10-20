using System;

namespace Printer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("Io");
            InherancePrinter inherancePrinter = new InherancePrinter();
            inherancePrinter.Print("IO");
        }
    }
}
