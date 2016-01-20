using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat2
{
    class Vehicle
    {
        private string name;
        private int speed;
        private int tyres;
        private string combined;

        public Vehicle(string name, int speed, int tyres)
        {
            this.name = name;
            this.speed = speed;
            this.tyres = tyres;
        }
        public void PrintData()
        {
            Console.WriteLine("Auton nimi: " +name + "\nAuton nopeus: " + speed + "\nAuton rengasmäärä: " + tyres);
        }

        public void ToString() {
            combined = "Auton nimi: " + name + "\nAuton nopeus: " + speed + "\nAuton rengasmäärä: " + tyres;
            Console.WriteLine("\nJa sama string-muodossa:\n" +combined);
        }
    }
    class Harjoitus4
    {
        static void Main(string[] args)
        {
            Vehicle citroen = new Vehicle("kolmio", 60, 4);
            citroen.PrintData();
            citroen.ToString();
        }
    }
}
