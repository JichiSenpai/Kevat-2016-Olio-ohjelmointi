using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat1
{
    class Harjoitus18
    {
        static void Main(string[] args)
        {
            string uinput;
            char[] stringcpy;
            string inputcpy;

            Console.Write("Anna lause > ");
            uinput = Console.ReadLine();

            stringcpy = uinput.ToCharArray();
            Array.Reverse(stringcpy);

            inputcpy = new string(stringcpy);
            Console.WriteLine("Antamasi lauseesi: " + uinput);
            Console.WriteLine("Antamasi lause takaperin: " + inputcpy);
        
            if (uinput == inputcpy)
            {
                Console.WriteLine("Antamasi lause on palindromi");
            }
        }
    }
}
