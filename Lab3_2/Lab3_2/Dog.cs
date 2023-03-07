using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    internal class Dog : IAnimal 
    {
        public String Name { get; set; }

        public String Color { get; set; }

        public int Height { get; set; }

        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("Dog eats meat.");
        }

        public string Cry()
        {
            return "Woof!";
        }
    }
}
