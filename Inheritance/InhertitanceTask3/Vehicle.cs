using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace InhertitanceTask3
{
    abstract class Vehicle
    {
        public double Price { get; set; }
        public double Speed { get; set; }
        public DateTime YearOfProduction { get; set; }

        public Vehicle(double price, double speed, DateTime year)
        {
            Price = price;
            Speed = speed;
            YearOfProduction = year;
        }
        public void Show()
        {
            Console.WriteLine( "New vehicle properties:" );
            Console.WriteLine("This vehicle is {0}", this.GetType().Name);
            PropertyInfo[] properties = this.GetType().GetProperties();
            foreach (var prop in properties)
            {
                Console.WriteLine(prop.Name + " = " + prop.GetValue(this).ToString());
            }
            Console.WriteLine("***************************");
        }

    }
}
