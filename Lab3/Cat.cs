using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Cat : Animal //Cat method that implement the animal class
    {
        public Cat(string name, string colour, int age) : base(name, colour, age)
        {
            Name = name;
            Colour = colour;
            Age = age;
        }
    

        //cat method that prints cats eat mice
        public override void Eat() 
        {
            Console.WriteLine("Cats eat mice");
        }
    }
}
