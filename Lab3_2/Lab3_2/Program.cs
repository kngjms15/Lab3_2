using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_2
{
    internal class Program
    {
        //Lab 3_2: Interfaces and Abstract Classes
        //James Bareng - 000499449
        static void Main(string[] args)
        {

            // Dog 
            Console.WriteLine("Enter a dog name: ");
            string dogName = Console.ReadLine();

            Dog dog = new Dog();
            dog.Name= dogName;

            Console.WriteLine("Enter the dog's height: ");
            int dogHeight = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the dog's color: ");
            string dogColor = Console.ReadLine();
            dog.Color = dogColor;

            Console.WriteLine($"Name: {dog.Name}, Color: {dog.Color}, Height: {dog.Height}");
            dog.Eat();
            Console.WriteLine(dog.Cry());

            Console.ReadKey();
            // Cat
            Console.WriteLine("Enter a cat name: ");
            string catName = Console.ReadLine();

            Cat cat = new Cat();
            cat.Name = catName;

            Console.WriteLine("Enter the cat's height: ");
            int catHeight = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the cat's color: ");
            string catColor = Console.ReadLine();
            cat.Color = catColor;

            Console.WriteLine($"Name: {cat.Name}, Color: {cat.Color}, Height: {cat.Height}");
            cat.Eat();
            Console.WriteLine(cat.Cry());

            Console.ReadKey();
        }
    }
}
