using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vehicles

       

            //Create 4 instances: Set the properties with object initializer syntax

            //1 Car, 1 Motorcycle
            //2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes - new it up as one of each derived class

            var car = new Car() { Year = 2008, Make = "Honda", Model = "Civic", HasTrunk = true };
            var motorcycle = new Motorcycle() { Year = 2012, Make = "Ducati", Model = "Tamiya", HasSideCart = false };
            
            Vehicle v1 = new Car() { Year = 2012, Model = "Toyota", Make = "Yaris", HasTrunk = false};
            Vehicle v2 = new Motorcycle() { Year =2022 , Make ="Ural" , Model ="Sahara" , HasSideCart = true};
            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            vehicles.Add(car);
            vehicles.Add(motorcycle);
            vehicles.Add(v1);
            vehicles.Add(v2);

            //car.DriveVirtual();
            //motorcycle.DriveAbstract();


            //Add the 4 vehicles to the list

            //Using a foreach loop iterate over each of the properties
            // Call each of the drive methods for one car and one motorcycle

            foreach (var item in vehicles)
            {
                Console.WriteLine($"{item.Year} {item.Make} {item.Model}\n");
                item.DriveAbstract();
                Console.WriteLine();
                item.DriveVirtual();
                Console.WriteLine();


            }


           

            #endregion
            Console.ReadLine();
        }
    }
}
