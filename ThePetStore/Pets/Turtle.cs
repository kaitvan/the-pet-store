using System;
using System.Collections.Generic;
using System.Text;

namespace ThePetStore.Pets
{
    class Turtle
    {
        // Properties --> things that are externally consumable
        public string Name { get; set; }
        public string Size { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        // Fields --> internal private stuff like state in react (usually set to private)
        private bool _isHungry = false;

        // Constructor --> required to be instantiated when a new object is created using this class
        // no return type, it creates a new instance of the class object
        public Turtle(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"This turtle's name is {name} and it's age is {age}.");

        }

        // Method
        public void Eat(string foodType)
        {
            if (_isHungry)
            {
                Console.WriteLine($"The turtle stretches their neck out and munches on the {foodType}.");
            }
            else
            {
                Console.WriteLine("Shakes their head and says no thanks.");
                _isHungry = true;
            }
        }

        public void ShowTime(string occasion)
        {
            if (occasion != null)
            {
                Console.WriteLine($"It is a {occasion}!");
            } else
            {
                Console.WriteLine($"No occasion.");
            }
            DressUp("tie");
        }


        // Method overloading --> allows a method to be called again with different parameters

        public void Eat()
        {
            Eat("pellets");
        }


        // Private Method --> only used within this class
        private void DressUp(string clothing)
        {
            Console.WriteLine($"The turtle is wearing a {clothing}");
        }
    }
}
