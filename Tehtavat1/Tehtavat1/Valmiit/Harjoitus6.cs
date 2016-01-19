using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat1
{
    class Harjoitus6
    {
        static void Main (string[] args)
        {
            double matka;
            double bensanmaara;
            double bensanhinta;
            double kulutus;
            double hinta;

            kulutus = 7.02;
            hinta = 1.595;

            Console.Write("Anna matka > ");
            matka = int.Parse(Console.ReadLine()) / 100.00;

            bensanmaara = matka * kulutus;
            bensanhinta = bensanmaara * hinta;
            

            Console.Write("Bensaa kuluu " + bensanmaara.ToString("#.##") + " litraa, kustannus " + bensanhinta.ToString("#.##") + " euroa");
            Console.ReadLine();
        }
    }
}
