using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    internal interface IAnimal
    {
        string Name { get; set; }

        string Color { get; set; }

        int Height { get; set; }

        int Age { get; set; }

        void Eat(); 
        //?? The Eat method is an "abstract method"? I get an error that this is not allowed??
        string Cry();


    }
}
