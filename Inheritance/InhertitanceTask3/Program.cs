using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertitanceTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Plane(600000, 1000, new DateTime(2018, 5, 8),100, 180));
            vehicles.Add(new Ship(500000, 45, new DateTime(1987, 4, 5), 100, "Bagamas"));
            vehicles.Add(new Car(30000, 150, new DateTime(2016, 11, 12)));

            foreach (var vehicle in vehicles)
            {
                vehicle.Show();
            }

            Console.ReadLine();

        }
    }
}
