using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public string Year { get; set; } = "2010";

        public string Make { get; set; } = "Ford";

        public string Model { get; set; } = "4x4";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Drive virtual vehicle.");
        }            
    }
}
