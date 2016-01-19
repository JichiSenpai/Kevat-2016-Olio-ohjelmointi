using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat1
{
    class Harjoitus8
    {
        static void Main(string[] args)
        {
            int luku1;
            int luku2;
            int luku3;

            Console.Write("Anna luku > ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna luku > ");
            luku2 = int.Parse(Console.ReadLine());
            Console.Write("Anna luku > ");
            luku3 = int.Parse(Console.ReadLine());

            if (luku1 > luku2 && luku1 > luku3) {
                Console.Write("Suurin luku on " + luku1);
            }
            if (luku2 > luku1 && luku2 > luku3)
            {
                Console.Write("Suurin luku on " + luku2);
            }
            else
            {
                Console.Write("Suurin luku on " + luku3);
            }
        }
    }
}
