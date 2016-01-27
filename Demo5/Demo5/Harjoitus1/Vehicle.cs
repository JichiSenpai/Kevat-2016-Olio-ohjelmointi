using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5.Harjoitus1
{
    class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        
        public void RemoveTyres() {
            tyres.Clear();
        }

        public void AddTyre(Tyre t)
        {
            tyres.Add(t);
        }

        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;

            tyres = new List<Tyre>();

            AddTyre(new Tyre("Nokia", "asdasd123", "asdasd123"));
            AddTyre(new Tyre("Nokia", "asdasd123", "asdasd123"));
            AddTyre(new Tyre("Nokia", "asdasd123", "asdasd123"));
            AddTyre(new Tyre("Nokia", "asdasd123", "asdasd123"));
        }

        public override string ToString()
        {
            string s = "Vehicle: " + Brand + ", " + Model;

            foreach(Tyre t in tyres)
            {
                s += "\n";
                s += t.ToString();
            }

            return s;
        }
        
        private List<Tyre> tyres;
    }
}
