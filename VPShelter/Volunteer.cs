using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Volunteer: Employee
    {
        public override void ClockIn()
        {
            Console.WriteLine("Becky punched into her shift on time.");
        }

        public override void ShowID()
        {
            Console.WriteLine("Becky inserted her ID insto the security scanner.");
        }

        public void Feed()
        {
            Console.WriteLine("All pets have been fed.");
        }
        
    }
}
