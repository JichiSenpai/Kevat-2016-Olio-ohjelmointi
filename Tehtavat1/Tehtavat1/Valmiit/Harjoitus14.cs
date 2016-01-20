using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat1
{
    class Harjoitus14
    {
        static int nolla = 0;
        static int yks = 0;
        static int kaks = 0;
        static int kol = 0;
        static int nel = 0;
        static int viis = 0;

        static void Main(string[] args)
        {
          

            bool mainloop;

            mainloop = true;

            while (mainloop)
            {
                Console.Write("Anna luku > ");
                int templuku = int.Parse(Console.ReadLine());
                
                    switch (templuku)
                    {
                        case 0: nolla++;  continue;
                        case 1: yks++; continue;
                        case 2: kaks++; continue;
                        case 3: kol++; continue;
                        case 4: nel++; continue;
                        case 5: viis++; continue;
                        case 69: mainloop = false; break;
                }
            }

            Console.Write("Arvosanat:");
            Console.Write("\n0: ");
            for (int l0 = 0; l0 < nolla; l0++)
            {
                Console.Write("*");
            }
            Console.Write("\n1: ");
            for (int l1 = 0; l1 < yks; l1++)
            {
                Console.Write("*");
            }
            Console.Write("\n2: ");
            for (int l2 = 0; l2 < kaks; l2++)
            {
                Console.Write("*");
            }
            Console.Write("\n3: ");
            for (int l3 = 0; l3 < kol; l3++)
            {
                Console.Write("*");
            }
            Console.Write("\n4: ");
            for (int l4 = 0; l4 < nel; l4++)
            {
                Console.Write("*");
            }
            Console.Write("\n5: ");
            for (int l5 = 0; l5 < viis; l5++)
            {
                Console.Write("*");
            }
            Console.Write("\n");
        }
    }
}
