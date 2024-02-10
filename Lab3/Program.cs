using System;


namespace Lab3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ask the user for a dog name
            Console.WriteLine("What is your dogs name: ");
            string dogName = Console.ReadLine();

            //create the dog type object
            Animal dog = new Dog(dogName, "brown", 5);
            //execute getter and setter method to print the properties
            Console.WriteLine($"Name: {dog.Name}, Colour: {dog.Colour}, Age: {dog.Age}");
            //this is the Eat method implemented by the dog class
            dog.Eat();

            //ask the user for a cat name
            Console.WriteLine("What is your cat's name: ");
            string catName = Console.ReadLine();
            
            //create the cat type object
            Animal cat = new Cat(catName, "white", 10);
            Console.WriteLine($"Name: {cat.Name}, Colour: {cat.Colour}, Age: {cat.Age}");
            //this is the eat method implemented by the cat class
            cat.Eat();

            
        }
    }
    abstract class Animal
    {
        //class properties with getters and setters
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }

        //constructor
        public Animal (string name, string colour, int age)
        {
            Name = name;
            Colour = colour;
            this.Age = age;
        }

        //method called eat that is an abstract method of type void
        public abstract void Eat();

    }
}