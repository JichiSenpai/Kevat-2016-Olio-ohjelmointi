using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat1
{
    class Harjoitus2
    {
        static void Main(string[] args)
        {
            int uinput;

            Console.WriteLine("Anna pistemäärä: ");
            uinput = int.Parse(Console.ReadLine());

            if (uinput == 0 || uinput == 1)
            {
                Console.WriteLine("Annetun pistemäärän arvosana on 0.");
            }
            if (uinput == 2 || uinput == 3)
            {
                Console.WriteLine("Annetun pistemäärän arvosana on 1.");
            }
            if (uinput == 4 || uinput == 5)
            {
                Console.WriteLine("Annetun pistemäärän arvosana on 2.");
            }
            if (uinput == 6 || uinput == 7)
            {
                Console.WriteLine("Annetun pistemäärän arvosana on 3.");
            }
            if (uinput == 8 || uinput == 9)
            {
                Console.WriteLine("Annetun pistemäärän arvosana on 4.");
            }
            if (uinput == 10 || uinput == 11 || uinput == 12)
            {
                Console.WriteLine("Annetun pistemäärän arvosana on 5.");
            }
        }
    }
}
