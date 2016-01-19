using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat1
{
    class Harjoitus1
    {
        static void Main(string[] args)
        {

            bool loop = true;
            int uinput;

            while (loop)
            {
                Console.WriteLine("Anna luku 1, 2 tai 3: ");
                uinput = int.Parse(Console.ReadLine());
                if (uinput == 1)
                {
                    Console.WriteLine("Annoit luvun yksi");
                    break;
                }
                if (uinput == 2)
                {
                    Console.WriteLine("Annoit luvun kaksi");
                    break;
                }
                if (uinput == 3)
                {
                    Console.WriteLine("Annoit luvun kolme");
                    break;
                }
                else {
                    Console.WriteLine("Luku ei ole 1, 2 tai 3, yritä uudestaan");
                    Console.ReadLine();
                    continue;
                }
            }

        }
    }
}
