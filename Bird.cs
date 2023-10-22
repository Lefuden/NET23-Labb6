using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6
{
    internal class Bird : Animal
    {
        private bool Dive {get; }
        public Bird(string race = "bird", string name = "Charles", string colour = "blue", string legs = "12", string fur = "no", bool dive = true) 
            : base(race, name, colour, legs, fur)
        {
            Dive = dive;
        }
        internal override void AnimalStats()
        {
            base.AnimalStats();
            Console.WriteLine(Dive ? "it can dive" : "it can't dive");
        }
        //unique method
        internal void Fly()
        {
            Console.WriteLine("most birds can fly");
        }
        internal override void LivesWhere()
        {
            Console.WriteLine("they can be found anywhere in the world");
        }
        internal override void MakeSound()
        {
            Console.WriteLine("chirp chirp");
        }
    }
}
