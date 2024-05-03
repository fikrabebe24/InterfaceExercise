using System;
using System.Reflection;

namespace InterfaceExercise
{
	public class Truck: IVehicle, ICompany
	{
        public string CompanyName { get; set; } = "Honda Motors";
        public bool IsPublic { get; set; } = true;
        public int TopSpeed { get; set; } = 120;
        public bool IsNew { get; set; } = false;
        public int NumberOfDoors { get; set; } = 2;
        public string OwnerName { get; set; } = "Yonas";
        public string Make { get; set; } = "Toyota";

        void IVehicle.DisplayDetails()
        {
            Console.WriteLine($"I am {OwnerName}'s {Make} Truck, and my top speed is {TopSpeed}");
        }
    }
	

}

