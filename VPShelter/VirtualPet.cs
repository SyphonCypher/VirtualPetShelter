using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class VirtualPet
    {
        //Fields
        public int hunger = 5;
        public int thirst = 5;
        public int boredom = 5;
        public string name;
        public string descrip;

        //Properties
        public string GetName
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string GetDescrip
        {
            get { return this.descrip; }
            set { this.descrip = value; }
        }

        public int GetHunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int GetThirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }

        public int GetBoredom
        {
            get { return this.boredom; }
            set { this.boredom = value; }
        }

        //Constructors
        public VirtualPet()
        {
            //Default constructor
        }

        public VirtualPet(string name, string descrip, int hunger, int thirst, int boredom)
        {
            this.GetHunger = hunger;
            this.GetThirst = thirst;
            this.GetBoredom = boredom;
            this.GetName = name;
            this.GetDescrip = descrip;
        }

        public VirtualPet(string name, string descrip)
        {
            this.GetName = name;
            this.GetDescrip = descrip;
        }

        //Methods
        public void GetFood()
        {
            GetHunger = 0;
            GetThirst++;
        }

        public void GetWater()
        {
            GetThirst = 0;

        }

        public void GetPlay()
        {
            GetBoredom = 0;
            GetHunger ++;
            GetThirst++;
        }

        
    }
}
