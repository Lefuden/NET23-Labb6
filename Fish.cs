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
        public Fish(string name = "Bob", string colour = "seethrough", string race = "fish", int height = 15, int weight = 1, bool waterType = true) 
            : base(name, colour, race, height, weight)
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
            Console.WriteLine("fish can swim really well");
        }
        internal override void LivesWhere()
        {
            Console.WriteLine("fish tend to live underwater");
        }
        internal override void MakeSound()
        {
            Console.WriteLine("blub blub..");
        }
        internal override void AllInfo()
        {
            base.AllInfo();
            Swim();
        }
    }
}
