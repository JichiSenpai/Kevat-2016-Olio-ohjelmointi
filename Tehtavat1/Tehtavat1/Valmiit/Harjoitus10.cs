using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat1
{
    class Harjoitus10
    {
        static void Main(string[] args)
        {
            int[] table;
            table = new int[9] {1, 2, 33, 44, 55, 68, 77, 96, 100};
            int looppi;
            looppi = 0;

            while (looppi != 9)
            {
                Console.Write(table[looppi] + "\n");
                if (table[looppi] % 2 == 0)
                {
                    Console.Write("HEP\n\n");
                }
                looppi++;
            }
        }
    }
}
