using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle //create non-abstract class: Car, that inherits from Vehicle
    {
        public Car()
        {

        }
        public bool HasTrunk { get; set; } = true; //Add a distict property in the derived class such as HasTrunk for Car

        public override void DriveAbstract()
        {
            //Provide the implementations for the abstract method
            Console.WriteLine("car drive");
        }
       

    }
      
   
            
}

