using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    internal class Cat
    {
        public String Name { get; set; }

        public String Color { get; set; }

        public int Height { get; set; }

        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("Cat eats mice.");
        }

        public string Cry()
        {
            return "Meow!";
        }
    }
}
