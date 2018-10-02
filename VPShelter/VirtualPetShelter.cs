using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    static class VirtualPetShelter
    {
        
        static List<VirtualPet> Pets { get; set; }
        static List<Employee> Employees { get; set; }

        static VirtualPetShelter()
        {
            Pets = new List<VirtualPet>();
            Employees = new List<Employee>();
        }
    }
}
