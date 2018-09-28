using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Manager: Employee
    {
        public override void ClockIn()
        {
            Console.WriteLine("You're a salary man, Bob. You don't clock in.");
        }

        public override void ShowID()
        {
            Console.WriteLine("Bob inserts his ID into the security scanner.");
        }

        public void Inspire()
        {
            Console.WriteLine("Bob gathers all the volunteers and hypes them up with an inspiring speech.");
        }

        public void Adopt()
        {
            
        }
    }
}
