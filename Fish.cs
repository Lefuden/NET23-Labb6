using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb6
{
    internal class Fish : Animal
    {
        private bool WaterType {get; }
        public Fish(string race = "fish", string name = "Bob", string colour = "seethrough", string legs = "5", string fur = "no", bool waterType = true) 
            : base(race, name, colour, legs, fur)
        {
            WaterType = waterType;
        }
        internal override void AnimalStats()
        {
            base.AnimalStats();
            Console.WriteLine(WaterType ? "it lives in freshwater" : "it lives in saltwater");
        }
        //unique method
        internal void Swim()
        {
            Console.WriteLine("they can swim really well");
        }
        internal override void LivesWhere()
        {
            Console.WriteLine("they tend to live underwater");
        }
        internal override void MakeSound()
        {
            Console.WriteLine("blub blub..");
        }
    }
}
