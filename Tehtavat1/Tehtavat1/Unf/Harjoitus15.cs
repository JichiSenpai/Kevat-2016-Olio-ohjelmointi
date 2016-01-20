using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat1
{
    class Harjoitus15
    {

            static void Main(string[] args)
        {
            int uinput;

            Console.Write("Anna luku > ");
            uinput = int.Parse(Console.ReadLine());

            //7
            for (int i = 0; i <= uinput-2; i++)
            {
                Console.Write("\n");
                for (int e = uinput; e > i; e--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                for (int f = uinput; f < i; f++)
                {
                    Console.Write("*");
                }
            }
            int k = 0;
            while (k != 3)
            {
                for (int e = uinput; e > k; e--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < k; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
                k++;
            }
            

        }
    }
}
