using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oliotesti
{
    class Opiskelija
    {
        private string name;
        private int speed;
        private int tyres;
        private string combined;

        public Opiskelija(string name, int speed, int tyres)
        {
            this.name = name;
            this.speed = speed;
            this.tyres = tyres;
        }
        public void PrintData()
        {
            Console.WriteLine("Auton nimi: " + name + "\nAuton nopeus: " + speed + "\nAuton rengasmäärä: " + tyres);
        }

        public void ToString()
        {
            combined = "Auton nimi: " + name + "\nAuton nopeus: " + speed + "\nAuton rengasmäärä: " + tyres;
            Console.WriteLine("\nJa sama string-muodossa:\n" + combined);
        }
    }
    class Harjoitus5
    {

    }
}
