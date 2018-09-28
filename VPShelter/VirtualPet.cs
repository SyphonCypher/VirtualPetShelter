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
        private int hunger = 5;
        private int thirst = 5;
        private int boredom = 5;
        private string name;
        private string descrip;

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

        public VirtualPet(int hunger, int thirst, int boredom, int sickness, string name, string descrip)
        {
            this.GetHunger = hunger;
            this.GetThirst = thirst;
            this.GetBoredom = boredom;
            this.GetName = name;
            this.GetDescrip = descrip;
        }

        //Methods
        public void GetFood()
        {
            Console.WriteLine(" ");
            GetHunger = 0;
            GetThirst++;
        }

        public void GetWater()
        {
            Console.WriteLine(" ");
            GetThirst = 0;
        }

        public void GetPlay()
        {
            Console.WriteLine(" ");
            GetBoredom = 0;
        }

        
    }
}
