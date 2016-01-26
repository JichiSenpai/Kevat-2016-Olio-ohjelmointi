using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oliotesti
{
    class Videopeli
    {
        private string title;
        private int releasedate;
        private string platform;
        private string developer;
        private string publisher;
        private bool multiplatform;
        private double metacritic;
        private string combined;

        public Videopeli(string title, int releasedate, string platform, string developer, string publisher, bool multiplatform, double metacritic)
        {
            this.title = title;
            this.releasedate = releasedate;
            this.platform = platform;
            this.developer = developer;
            this.publisher = publisher;
            this.multiplatform = multiplatform;
            this.metacritic = metacritic;

        }
        public void PrintData()
        {
            Console.WriteLine("\nNimi: " + title + "\nJulkaisupäivä: " + releasedate + "\nAlusta: " + platform + "\nKehittäjä: " + developer + "\nJulkaisija: " + publisher + "\nMetacritic arvosana: " + metacritic);
        }

        public void ToString()
        {
            combined = title + " " + releasedate + " " + platform + " " + developer + " " + publisher + " " + metacritic;
            Console.WriteLine("\nPelin perustiedot stringissä:\n" + combined);
        }
        public void PrintDevTeam()
        {
            Console.WriteLine("\n" + title + " - " + developer + " - " + publisher);
        }

        public void IsMultiplatform()
        {
            if (multiplatform == true)
            {
                Console.WriteLine("\nTämä videopeli on saatavilla seuraaville alustoille: " + platform);
            }
            else
            {
                Console.WriteLine("\nTämä videopeli vain alustalle " + platform);
            }
        }
    }
    class Harjoitus6
    {
        static void Main(string[] args)
        {
            Videopeli[] asdasd123 = new Videopeli[4];
            asdasd123[0] = new Videopeli("Sly 2: Band of Thieves", 2005, "PS2", "Sucker Punch", "Sucker Punch", false, 90);
            asdasd123[1] = new Videopeli("Star Wars: Episode 1 Racer", 1999, "PC, N64, Dreamcast", "Lucasarts", "Lucasarts", true, 99);
            asdasd123[2] = new Videopeli("Kingdom Hearts 2", 2004, "PS2", "Square Enix", "Square Enix", false, 88.9);
            asdasd123[3] = new Videopeli("Blocks vs. More Circular Blocks", 2014, "Android, PC", "Jaakko Tammela", "N/A", true, 100);

            asdasd123[0].PrintData();
            asdasd123[1].ToString();
            asdasd123[2].PrintDevTeam();
            asdasd123[3].IsMultiplatform();

            for (int i = 0; i < 4; i++)
            {
                asdasd123[i].PrintData();
            }
        }
    }
}