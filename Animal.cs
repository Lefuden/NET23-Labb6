using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6
{
    internal abstract class Animal
    {
        //a whole bunch of variables, Name is public as I use it elsewhere too.
        public string Name { get; set; }
        private string Race { get; }
        private string Colour { get; }
        private int Legs { get; }
        private string Fur { get; }
        private int Height { get; }
        private int Weight { get; }
        
        //constructor with boring default values.
        internal Animal(string name = "Unknown", string colour = "unknown", string race = "unknown", int height = 5, 
            int weight = 10, int legs = 0, string fur = "unknown")
        {
            Race = race;
            Name = name;
            Colour = colour;
            Legs = legs;
            Fur = fur;
            Height = height;
            Weight = weight;
        }
        
        //empty methods that will be used by the animals
        internal abstract void MakeSound();
        internal abstract void LivesWhere();

        //virtual methods which will change slightly depending on animal
        internal virtual void AnimalStats()
        {
            Console.WriteLine($"{Name} the {Colour} {Race} weighs {Weight}kg and measures {Height}cm");

            if (Fur != "unknown" && Legs == 2)
            {
                Console.WriteLine($"it has {Fur} fur and is bipedal");
            }
            else if (Fur == "unknown" && Legs != 0)
            {
                Console.WriteLine($"it walks on {Legs} legs");
            }
        }
        internal virtual void AllInfo()
        {
            AnimalStats();
            LivesWhere();
            MakeSound();
        }
    }
}
