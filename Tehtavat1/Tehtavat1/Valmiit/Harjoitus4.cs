using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat1
{
    class Harjoitus4
    {
        static void Main(string[] args)
        {
            int age;

            Console.Write("Anna ikäsi> ");
            age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("Olet alaikäinen.");
            }
            if (age >= 18 && age < 65)
            {
                Console.WriteLine("Olet aikuinen.");
            }
            if (age >= 65)
            {
                Console.WriteLine("Olet seniori.");
            }
        }
    }
}
