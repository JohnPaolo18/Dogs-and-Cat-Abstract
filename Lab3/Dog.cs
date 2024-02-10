using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Dog : Animal //dog method that implements the animal class
    {

        public Dog(string name, string colour, int age) : base(name, colour, age)
        {
            Name = name;
            Colour = colour;
            Age = age;
        }
    

        //eat method that print dogs eat meat
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }
    }
}
