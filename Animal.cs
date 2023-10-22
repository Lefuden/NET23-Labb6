using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6
{
    internal class Animal
    {
        //I ended up with two variables that doesn't make much sense for fish and birds, but I really couldn't think of something they all share.
        private string Race { get; }
        private string Name { get; }
        private string Colour { get; }
        private string Legs { get; }
        private string Fur { get; }
        //constructor
        internal Animal(string race = "unknown", string name = "Unknown", string colour = "unknown", string legs = "0", string fur = "unknown")
        {
            Race = race;
            Name = name;
            Colour = colour;
            Legs = legs;
            Fur = fur;
        }
        //virtual methods with default values to be used by the other classes
        internal virtual void MakeSound()
        {
            Console.WriteLine("Most animals can make a sound");
        }
        internal virtual void AnimalStats()
        {
            Console.WriteLine($"{Name} the {Colour} {Race} has {Legs} legs and {Fur} fur. ");
        }
        internal virtual void LivesWhere()
        {
            Console.WriteLine("Most animals can be found at the zoo");
        }
    }
}
