using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertitanceTask3
{
    class Plane : Vehicle
    {
        public double Height { get; set; }
        public int AmountOfPassengers { get; set; }
        public Plane(double price, double speed, DateTime year, double height, int amount) : base (price, speed, year)
        {
            Height = height;
            AmountOfPassengers = amount;
        }
    }
}
