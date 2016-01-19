using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat1
{
    class Harjoitus7
    {
        static void Main(string[] args)
        {
            int year;
            


            Console.Write("Anna vuosi > ");
            year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 | year % 400 == 0)
            {
                Console.Write("Vuosi " + year + " on karkausvuosi.");
                Console.ReadLine();
            }
            else {
                Console.Write("Vuosi " + year + " ei ole karkausvuosi.");
                Console.ReadLine();
            }
        }
    }
}
