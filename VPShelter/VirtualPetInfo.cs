using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class VirtualPetInfo: VirtualPet
    {
        private string petType;
        private string petDiet;

        public string GetType
        {
            get { return this.petType; }
            set { this.petType = value; }
        }

        public string GetDiet
        {
            get { return this.petDiet; }
            set { this.petDiet = value; }
        }

    }
}
