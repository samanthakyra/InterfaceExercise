using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public string FuelType { get; set; }
        public bool IsDriveable { get; set; }
        public string CompanyName { get; set; }
        public string Logo { get; set; }
        public bool HasTrunk = true;
        public bool HasBackRow = true;
    }
}

