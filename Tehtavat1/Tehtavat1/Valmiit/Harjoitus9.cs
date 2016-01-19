using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat1
{
    class Harjoitus9
    {
        static int kokoluku;
        static void Main(string[] args)
        {
            
            bool mainloop;

            mainloop = true;

            while (mainloop)
            {
                Console.Write("Anna luku > ");
                int templuku = int.Parse(Console.ReadLine());
                if (templuku == 0)
                {
                    break;
                }
                else {
                    kokoluku = kokoluku + templuku;
                }
            }

            Console.Write("Lukujen summa on " + kokoluku);
            Console.Read();
        }
    }
}
