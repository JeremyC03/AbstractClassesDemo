using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Drive abstract motorcycle.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Drive virtual motorcycle.");
        }
    }
}
