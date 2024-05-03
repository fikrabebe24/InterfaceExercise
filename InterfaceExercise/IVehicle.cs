using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace InterfaceExercise
{
	public interface IVehicle
	{
		public int TopSpeed { get; set; }

		public bool IsNew { get; set; }

		public int NumberOfDoors {get; set;}

		public string OwnerName { get; set; }

		public void DisplayDetails();
		

    }
}

