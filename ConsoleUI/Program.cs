﻿using System;
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
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
            Car car = new Car() 
            { 
                Year = "2012", 
                Make = "Toyota", 
                Model = "Corola S", 
                HasTrunk = true 
            };

            Motorcycle motorcycle = new Motorcycle() 
            { 
                Year = "2006", 
                Make = "Aoshima", 
                Model = "Honda AC16 Ape", 
                HasSideCart = false 
            };

            Vehicle vehicle1 = new Car()
            {
                Year = "2011",
                Make = "Ford",
                Model = "Explorer",
                HasTrunk = true
            };

            Vehicle vehicle2 = new Motorcycle()
            {
                Year = "2017",
                Make = "Velorex",
                Model = "563",
                HasSideCart = true
            };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(car);
            vehicles.Add(motorcycle);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            foreach (Vehicle item in vehicles)
            {
                Console.WriteLine($"Year : {item.Year}");
                Console.WriteLine($"Make : {item.Make}");
                Console.WriteLine($"Model : {item.Model}");
                Console.WriteLine();
            }
            // Call each of the drive methods for one car and one motorcycle

            car.DriveAbstract();
            car.DriveVirtual();
            Console.WriteLine();

            motorcycle.DriveAbstract();
            motorcycle.DriveVirtual();

            #endregion            
            Console.ReadLine();
        }
    }
}
