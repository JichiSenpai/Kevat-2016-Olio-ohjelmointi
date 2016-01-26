using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oliotesti
{
    class Opiskelija
    {
        private string enimi;
        private string snimi;
        private string tunnus;
        private string sukupuoli;
        private string sposti;
        private int svuosi;
        private string puh;
        private double keskiarvo;
        private string combined;

        public Opiskelija(string enimi, string snimi, string tunnus, string sukupuoli, int svuosi, string sposti, string puh, double keskiarvo)
        {
            this.enimi = enimi;
            this.snimi = snimi;
            this.tunnus = tunnus;
            this.sukupuoli = sukupuoli;
            this.sposti = sposti;
            this.svuosi = svuosi;
            this.puh = puh;
            this.keskiarvo = keskiarvo;
        }
        public void PrintData()
        {
            Console.WriteLine("\nNimi: " + enimi + " " + snimi + "\nRyhmätunnus: " + tunnus + "\nSukupuoli: " + sukupuoli + "\nSyntymävuosi: " + svuosi + "\nSähköposti: " + sposti + "\nPuhelinnnumero: " + puh + "\nKeskiarvo:" + keskiarvo);
        }

        public void ToString()
        {
            combined = enimi + " " + snimi + " " + tunnus + " " + sukupuoli + " " + svuosi;
            Console.WriteLine("\nOpiskelijan perustiedot stringissä:\n" + combined);
        }
        public void PrintContact()
        {
            Console.WriteLine("\n" + enimi + " " + snimi + "\nSähköposti: " + sposti + "\nPuhelinnnumero: " + puh);
        }

        public void CheckLowGPA()
        {
            if (keskiarvo < 2)
            {
                Console.WriteLine("\nOpiskelijan " + enimi + " " + snimi + " keskiarvo (" + keskiarvo + ") on alhainen.");
            }
        }
    }
    class Harjoitus5
    {
        static void Main(string[] args)
        {
            Opiskelija jamk1 = new Opiskelija("Jaakko", "Tammela", "K1697", "Mies", 1996, "tammi_574@hotmail.com", "045-3227518", 2.5);
            Opiskelija jamk2 = new Opiskelija("Lotta", "Tammela", "H8656", "Nainen", 1998, "siistisähköposti@gmail.com", "045-3227548", 4.8);
            Opiskelija jamk3 = new Opiskelija("Mikael", "Tammela", "K1589", "Mies", 1994, "mikael_123@hotmail.com", "045-3227674", 2.8);
            Opiskelija jamk4 = new Opiskelija("Nääly", "Petteri", "X1234", "N/A", 1969, "näälymail@123123.fi", "043-1231234", 1.2);
            Opiskelija jamk5 = new Opiskelija("Nörö", "Beetter", "Y4312", "N/A", 1973, "nörömail@123123.fi", "040-1234123", 1.1);

            jamk1.PrintData();
            jamk2.ToString();
            jamk3.PrintContact();
            jamk4.CheckLowGPA();
        }
    }
}
