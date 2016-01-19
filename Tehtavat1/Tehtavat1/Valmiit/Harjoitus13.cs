using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat1
{
    class Harjoitus13
    {
        static void Main(string[] args)
        {
            int luku1;
            int luku2;
            int luku3;
            int luku4;
            int luku5;

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

            int maxluku = luvut.Max();
            int minluku = luvut.Min();
            int kokoluku = luvut.Sum() - maxluku - minluku;

            Console.Write("Kokonaispisteet ovat " + kokoluku);

        }
    }
}
