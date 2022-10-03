using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main()
        {
            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var car = new Car()
            {
                NumberOfWheels = 4,
                NumberOfDoors = 4,
                FuelType = "Gasoline",
                IsDriveable = true,
                CompanyName = "AUDI",
                Logo = "4 rings"
            };
            var truck = new Truck()
            {
                NumberOfWheels = 4,
                NumberOfDoors = 2,
                FuelType = "Diesel",
                IsDriveable = true,
                CompanyName = "Ford",
                Logo = "spells out Ford"
            };
            var suv = new SUV()
            {
                NumberOfWheels = 4,
                NumberOfDoors = 4,
                FuelType = "Electric",
                IsDriveable = true,
                CompanyName = "Tesla",
                Logo = "cross-section of an electric motor"
            };

            var companyLot = new List<ICompany>();
            companyLot.Add(car);
            companyLot.Add(truck);
            companyLot.Add(suv);

            var vehicleLot = new List<IVehicle>();
            vehicleLot.Add(car);
            vehicleLot.Add(truck);
            vehicleLot.Add(suv);

            foreach (var vehicle in companyLot)
            {
                Console.WriteLine(vehicle.CompanyName);
                Console.WriteLine(vehicle.Logo);
            }
            foreach (var vehicle in vehicleLot)
            {
                Console.WriteLine(vehicle.NumberOfWheels);
                Console.WriteLine(vehicle.NumberOfDoors);
                Console.WriteLine(vehicle.FuelType);
                Console.WriteLine(vehicle.IsDriveable);
            }
        }
    }
}
