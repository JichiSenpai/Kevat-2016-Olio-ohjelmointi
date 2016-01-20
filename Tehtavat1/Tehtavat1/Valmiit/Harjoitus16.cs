using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat1
{
    class Harjoitus16
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int uinput;
            int randluku = rnd.Next(0, 100);
            int kerrat = 0;
            bool looppi = true;

            while (looppi) {
                Console.Write("Arvaa luku > ");
                uinput = int.Parse(Console.ReadLine());
                if (uinput > randluku)
                {
                    Console.Write("Luku on pienempi\n");
                    kerrat++;
                }
                if (uinput < randluku)
                {
                    Console.Write("Luku on suurempi\n");
                    kerrat++;
                }
                if (uinput == randluku)
                {
                    Console.Write("Arvasit luvun!\n");
                    kerrat++;
                    looppi = false;
                    break;
                }
            }

            Console.Write("Arvasit luvun " + kerrat + " kerralla\n");
        }
    }
}
