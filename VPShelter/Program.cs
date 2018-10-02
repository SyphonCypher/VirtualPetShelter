using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {


        static void Main(string[] args)
        {
            
            VirtualPet Shoober = new VirtualPet("Shoober", "Chunky", 5, 5, 5);
            VirtualPet Nibbles = new VirtualPet("Nibbles", "Hyper", 5, 5, 5);
            VirtualPet Hubert = new VirtualPet("Hubert", "Skinny", 5, 5, 5);
            

            Manager Bob = new Manager();
            Volunteer Becky = new Volunteer();

            Console.WriteLine("Welcome to Krang's Cavern! What employee type are you?");
            Console.WriteLine("1. Manager.");
            Console.WriteLine("2. Volunteer.");

            int input = int.Parse(Console.ReadLine());
            if(input == 1)
            {
                Console.WriteLine("Thanks for working for Krang's Cavern! What would you like to do?");
                Console.WriteLine("1. Scan ID.");
                Console.WriteLine("2. Clock in.");
                Console.WriteLine("3. Adopt out a pet.");
                Console.WriteLine("4. Inspire the volunteers.");
                int.Parse(Console.ReadLine());
                if(input == 1)
                {
                    Bob.ShowID();
                }
                else if(input == 2)
                {
                    Bob.ClockIn();
                }
                else if(input == 3)
                {
                    Bob.Adopt();
                }
                else if(input == 4)
                {
                    Bob.Inspire();
                }
                else
                {
                    return;
                }
            }
            else if(input == 2)
            {
                Console.WriteLine("Thanks for vulonteering at Krang's Cavern! What would you like to do?");
                Console.WriteLine(" ");
                Console.WriteLine("This is the status of your pets.");
                Console.WriteLine("Name |Description |Hunger |Thirst |Boredom");
                Console.WriteLine("-----|------------|-------|-------|-------");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("1. Show ID.");
                Console.WriteLine("2. Clock in.");
                Console.WriteLine("3. Feed pets.");
                int.Parse(Console.ReadLine());
                if(input == 1)
                {
                    Becky.ShowID();
                }
                else if(input == 2)
                {
                    Becky.ClockIn();
                }
                else if(input == 3)
                {
                    Becky.Feed();
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }




        }
    }
}
