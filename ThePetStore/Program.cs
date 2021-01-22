using System;

namespace ThePetStore.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle turtle1 = new Turtle("Mertle", 72);
            turtle1.Eat("lettuce");
            turtle1.Eat("lettuce");
            turtle1.Eat();
            turtle1.ShowTime("bar mitzvah");

            Scorpion scorpion = new Scorpion("Steven");
            scorpion.Attack();
        }
    }
}
