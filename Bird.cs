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
        public Bird(string name = "Charles", string colour = "blue", string race = "bird", int height = 23, int weight = 9, int legs = 4, bool dive = true) 
            : base(name, colour, race, height, weight, legs)
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
        internal override void AllInfo()
        {
            base.AllInfo();
            Fly();
        }
    }
}
