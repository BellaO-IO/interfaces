using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp17
{
    class Truck : IVehicle, ICompany
    {



        public Truck()
            {
            }

        public int BedSize { get; set; }
        public int Windows { get; set; }
        public int Doors { get; set; }
        public int Seats { get; set; }
        public string Name { get; set; }

        public string Model { get; set; }
        public string Make { get; set; }

        public int Year { get; set; }






    }
}
