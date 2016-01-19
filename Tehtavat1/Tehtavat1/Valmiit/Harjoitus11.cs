using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat1
{
    class Harjoitus11
    {
        static void Main(string[] args)
        {
            int uinput;

            Console.Write("Anna luku > ");
            uinput = int.Parse(Console.ReadLine()) + 1;

            for (int i=1; i<uinput; i++)
            {
                for (int j=0; j<i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
