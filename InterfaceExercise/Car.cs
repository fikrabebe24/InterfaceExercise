using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
	public class Car : IVehicle, ICompany
	{

        public int year { get; set; } = 2023;
        public int NumberOfDoors { get; set; }
        public string Make { get; set; } = "Tesla";
        public string Model { get; set; } = "Model Y"; 
        public int TopSpeed { get; set; } = 319;
        public bool IsNew { get; set; } = true;
        public string OwnerName { get; set; } = "Fifi";
        public string CompanyName { get; set; } = "Tesla";
        public bool IsPublic { get; set; } = true;

        public void DisplayDetails()
        {
            Console.WriteLine($"Iam {OwnerName}'s {Make} {Model}, my top speed is {TopSpeed}");
        }
        
    }
}

