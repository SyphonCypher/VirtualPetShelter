using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    abstract class Employee
    {
        public virtual string EmployeeID { get; set; }

        public virtual void ClockIn()
        {
            
        }

        public virtual void ShowID()
        {

        }
    }
}
