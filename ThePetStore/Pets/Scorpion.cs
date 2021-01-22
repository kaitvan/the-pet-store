using System;
using System.Collections.Generic;
using System.Text;

namespace ThePetStore.Pets
{
    class Scorpion
    {
        // inside class things are implicitly private
        public int StingerWidth { get; set; }
        public string Origin { get; set; }
        public string Name { get; set; }
        public bool DoesGlow { get; set; }

        public Scorpion(string name)
        {
            Name = name;
            DoesGlow = true;
        }

        // Methods

        // if glows, will sting

        public void Attack()
        {
            if (DoesGlow)
            {
                Console.WriteLine("You've been stung! Get to the hospital!!!");
            } else
            {
                Console.WriteLine("Scorpion kiss. You are fine.");
            }
        }
    }
}
