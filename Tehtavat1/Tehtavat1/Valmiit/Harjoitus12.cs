using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat1
{
    class Harjoitus12
    {
        static void Main(string[] args)
        {
            int[] luvut;
            luvut = new int[5];
            int loop;
            loop = 0;

            while (loop != 5)
            {
                Console.Write("Anna luku > ");
                luvut[loop] = int.Parse(Console.ReadLine());
                loop++;
            }

            Console.Write("\n");
            loop--;

            while (loop > -1)
            {
                Console.Write(luvut[loop]);
                loop--;
            }
            Console.Write("\n");

        }
    }
}
