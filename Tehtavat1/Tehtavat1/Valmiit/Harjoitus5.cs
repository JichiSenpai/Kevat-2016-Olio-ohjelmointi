using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtavat1
{
    class Harjoitus5
    {
        static void Main(string[] args)
        {
            int secondsinput;
            int seconds;
            int minutes;
            int hours;

            Console.Write("Anna sekuntit> ");
            secondsinput = int.Parse(Console.ReadLine());

            seconds = secondsinput % 60;
            minutes = secondsinput / 60;
            hours = secondsinput / 60 / 60;
            if (seconds >= 60)
            {
                seconds = seconds - 60;
                minutes++;
            }
            if (minutes >= 60)
            {
                minutes = minutes - 60;
                hours++;
            }

            Console.Write("Antamasi sekunttimäärä voidaan ilmaista näin: " + hours + " h " + minutes + " min " + seconds + "sec");
            Console.ReadLine();
        }
    }
}
