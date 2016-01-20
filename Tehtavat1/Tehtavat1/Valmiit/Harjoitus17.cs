using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat1
{
    class Harjoitus17
    {
        static void Main(string[] args)
        {
            int[] array1;
            array1 = new int[5] {1, 3, 2, 5, 4};
            int[] array2;
            array2 = new int[5] {7, 9, 6, 8, 10};
            int[] arraycombined;

            Array.Sort(array1);
            Array.Sort(array2);

            arraycombined = new int[array1.Length + array2.Length];
            array1.CopyTo(arraycombined, 0);
            array2.CopyTo(arraycombined, array1.Length);


            foreach (var item in array1)
            {
                Console.Write(item.ToString());
            }
            Console.Write("\n");
            foreach (var item in array2)
            {
                Console.Write(item.ToString());
            }
            Console.Write("\n");
            foreach (var item in arraycombined)
            {
                Console.Write(item.ToString());
            }
            Console.Write("\n");
        }
    }
}
