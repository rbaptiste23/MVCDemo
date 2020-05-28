using System;

namespace MVCDemo2
{
    public class CarModel : IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }



        public string Drive()
        {
            return "The Car is Driving";
        }


        public string Break()
        {
            return "The Car is Breaking";
        }


    }
}
