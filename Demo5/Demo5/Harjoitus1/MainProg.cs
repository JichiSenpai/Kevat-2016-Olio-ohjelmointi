using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5.Harjoitus1
{
    class MainProg
    {
        static void Main(string[] args)
        {
            Vehicle mycar = new Vehicle("Toyota", "asdasd123");
            Console.WriteLine(mycar.ToString());

            //mycar.tyres,Add(new Tyre("asd", "asd"));
            mycar.RemoveTyres();
            Console.WriteLine(mycar.ToString());

            mycar.AddTyre(new Tyre("Nokia", "123123", "asdasd"));
            Console.WriteLine(mycar.ToString());


        }
    }
}
