using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Printer
    {

        public virtual void Print(string value)
        {
            bool b = this.GetType().IsSubclassOf( new Printer().GetType());
            if (b)
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("its a child class");
            }
            else
            {
                Console.WriteLine("Print from base class");
                Console.WriteLine("Type definition");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("it s a base class");
            }
            
            Console.WriteLine("{0}", value);
        }
    }
}
