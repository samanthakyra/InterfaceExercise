using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
        {
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string FuelType { get; set; }
        public bool IsDriveable { get; set; }
        public string CompanyName { get; set; }
        public string Logo { get; set; }
        public bool HasBikeRack = true;
        public bool HasSunroof = true;
        }
}