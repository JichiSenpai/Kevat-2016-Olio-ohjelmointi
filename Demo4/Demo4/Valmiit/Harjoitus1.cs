using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4
{
    class Hissi
    {
        private readonly int maxFloors = 5;
        private readonly int minFloors = 1;
        
        private int Floor;
        private int oldFloor;
        public int floor{
            get
            {
                return Floor;
            }
            set
            {
                if (value > maxFloors)
                {
                    Console.WriteLine("Invalid floor. Too high.");
                    value = oldFloor;
                }
                if (value < minFloors)
                {
                    Console.WriteLine("Invalid floor. Too low.");
                    value = oldFloor;
                }
                else
                {
                    Floor = value;
                    oldFloor = value;
                }
            }
        }
        
        public Hissi()
        {

        }

        public Hissi(int uinput_floor)
        {
            Floor = uinput_floor;
        }
    }
    class Harjoitus1
    {
        static void Main(string[] args)
        {
            Hissi dynamo = new Hissi();

            bool looppi = true;

            while(looppi)
            {
                Console.Write("Give a new floor number> ");
                dynamo.floor = int.Parse(Console.ReadLine());
                Console.WriteLine("Elevator is now in floor: " + dynamo.floor);
            }
        }
    }
}
