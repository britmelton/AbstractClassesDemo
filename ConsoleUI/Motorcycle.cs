using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle //create non-abstract class: Motorcycle, that inherits from Vehicle
    {
        public Motorcycle()
            {

            }
        public bool HasSideCart { get; set; } = true;  //Add a distict property in the derived class such as HasSideCart for Motorcycle
       
        public override void DriveAbstract()
        {
            Console.WriteLine("motorcycle drive"); //Provide the implementations for the abstract method
        }
        public override void DriveVirtual()
        {
           Console.WriteLine("steer with handlebar");  //Only in the Motorcycle class will you override the virtual drive method
        }
        
       
    }
}
