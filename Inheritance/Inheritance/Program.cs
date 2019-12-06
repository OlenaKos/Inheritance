using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Printer basePrinter = new Printer();

            basePrinter.Print("two cups of coffee");

            PrinterEx childPrinter = new PrinterEx();

            childPrinter.Print("three glasses of water");

            Console.ReadLine();
        }
    }
}
