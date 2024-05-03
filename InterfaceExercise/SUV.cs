using System;
namespace InterfaceExercise
{
	public class SUV: IVehicle, ICompany
	{
        public string Model { get; set; } = "CRV";
        public string Make { get; set; } = "Honda";
        public int Year { get; set; } = 2023;
        public int TopSpeed { get; set; } = 177;
        public bool IsNew { get; set; } = false;
        public int NumberOfDoors { get; set; } = 4;
        public string OwnerName { get; set; } = "Jack";
        string ICompany.CompanyName { get; set; } = "Chrysler Group";
        bool ICompany.IsPublic { get; set; } = true;

        public void DisplayDetails()
        {
            Console.WriteLine($"I am a {Make}, {Model} and my top speed is {TopSpeed}");
        }
    }
}

