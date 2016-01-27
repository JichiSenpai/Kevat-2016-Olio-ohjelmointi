using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4
{
    class Styrkkari
    {
        private readonly int maxVolume = 100;
        private readonly int minVolume = 0;

        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= maxVolume) volume = value;
                else
                {
                        value = maxVolume;
                }
                if (value >= minVolume) volume = value;
                else
                {
                        volume = minVolume;
                }
            }
        }

        public Styrkkari()
        {

        }

        public Styrkkari(int uinput_volume)
        {
            Volume = uinput_volume;
        }
    }
    class Harjoitus2
    {
        static void Main(string[] args)
        {
            Styrkkari vahvari = new Styrkkari();

            bool looppi = true;

            while (looppi)
            {
                Console.Write("Give a new volume value> ");
                vahvari.Volume = int.Parse(Console.ReadLine());
                Console.WriteLine("-> Volume set to: " + vahvari.Volume);
            }
        }
    }
}