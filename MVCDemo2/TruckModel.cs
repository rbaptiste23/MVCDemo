using System;
using System.Collections.Generic;
using System.Text;

namespace MVCDemo2
{
    public class TruckModel : IVehicle
    {
        public string Color { get; set; }
        public string Make { get ; set; }
        public string Model { get; set ; }
        public int Year { get ; set ; }

        public string Break()
        {
            return "The Truck is Breaking";
        }

        public string Drive()
        {
            return "The Truck is Driving";
        }
    }
}
