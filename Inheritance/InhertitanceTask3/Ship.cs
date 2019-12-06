using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhertitanceTask3
{
    class Ship : Vehicle
    {
        public int AmountOfPassengers { get; set; }
        public string HomePort { get; set; }

        public Ship(double price, double speed, DateTime year, int amount, string port) : base (price, speed, year)
        {
            AmountOfPassengers = amount;
            HomePort = port; 
        }
    }
}
