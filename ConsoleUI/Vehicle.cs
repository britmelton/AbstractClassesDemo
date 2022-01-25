using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle //Create an abstract class called Vehicle
    {

        //The vehicle class shall have three string properties Year, Make, and Model
        // Set the defaults to something generic in the Vehicle class
        // Vehicle shall have an abstract method called DriveAbstract with no implementation
        // Vehicle shall have a virtual method called DriveVirtual with a base implementation.

        public int Year { get; set; } = 0000;
        public string Make { get; set; } = "Make";
        public string Model { get; set; } = "Model";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("steer with wheel");
        }
     
    }


}
