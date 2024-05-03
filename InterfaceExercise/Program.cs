using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            Car Car1 = new Car();

            Truck Truck2 = new Truck();

            SUV SUV1 = new SUV();

            Car1.TopSpeed = 300;
            Car1.IsNew = true;
            Car1.NumberOfDoors = 4;
            Car1.OwnerName = "Fifi";

            Truck2.TopSpeed = 150;
            Truck2.IsNew = false;
            Truck2.NumberOfDoors = 2;
            Truck2.OwnerName = "Yonas";



            SUV1.Model = "CR-V";
            SUV1.TopSpeed = 140;
            SUV1.IsNew = true;
            SUV1.NumberOfDoors = 4;
            SUV1.OwnerName = "Mita";


            var vehicleGroup = new List<IVehicle>() { Car1, Truck2, SUV1};

            foreach(var vehicle in vehicleGroup)
            {
                vehicle.DisplayDetails();
      
            }
            
            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.


            //Implement the stubbed out method in the derived classes.


            //In the scope of them method, use string interpolation to display property values.


            //In order to also interpolate values from ICompany, research how to extend interfaces.
            
        }
    }
}
