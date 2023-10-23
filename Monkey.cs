using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace Labb6
{
    internal class Monkey : Animal
    {
        //added a unique property to the monkeys
        internal bool CanClimb {get; set; }
        public Monkey(string name = "Bill", string colour = "pink", string race = "monkey", int height = 2, 
            int weight = 40, int legs = 7, string fur = "long", bool canClimb = false) 
            : base(name, colour, race, height, weight, legs, fur)
        {
            CanClimb = canClimb;
        }
        //overriding Animal class' AnimalStats method and adds the unique property.
        internal override void AnimalStats()
        {
            base.AnimalStats();
            Console.WriteLine(CanClimb ? "he's a good climber" : "he stays on the ground");
        }
        //added unique method
        internal void Behaviour()
        {
            Console.WriteLine("they can have a temper and throw things");
        }
        internal override void LivesWhere()
        {
            Console.WriteLine("most monkeys prefer the jungle");
        }
        internal override void MakeSound()
        {
            Console.WriteLine("ook ook");
        }
        internal override void AllInfo()
        {
            base.AllInfo();
            Behaviour();
        }
    }

    internal class Gorilla : Monkey
    {
        private bool IsBig { get; }
        public Gorilla(string name = "Arnold", string colour = "black", string race = "gorilla", int height = 200, 
            int weight = 182, int legs = 2, string fur = "short", bool canClimb = true, bool isBig = true) 
            : base( name, colour, race, height, weight, legs, fur)
        {
            CanClimb = canClimb;
            IsBig = isBig;
        }
        //overriding the method from monkey and adds in the unique property.
        internal override void AnimalStats()
        {
            base.AnimalStats();
            Console.WriteLine(IsBig ? $"{Name} is a big gorilla" : $"{Name} is a small gorilla");
        }
        //mr gorilla wants his own sound
        internal override void MakeSound()
        {
            Console.WriteLine("-slaps chest-");
        }
    }

    internal class Macaque : Monkey
    {
        //i'm not a monkey expert, but i think they all like bananas.
        private bool LikesBananas { get; }
        public Macaque(string name = "Sylvester", string colour = "white", string race = "macaque", int height = 57, 
            int weight = 22, int legs = 2, string fur = "flat", bool canClimb = false, bool likesBananas = true) 
            : base(name, colour, race, height, weight, legs, fur, canClimb)
        {
            LikesBananas = likesBananas;
        }
        internal override void AnimalStats()
        {
            base.AnimalStats();
            Console.WriteLine(LikesBananas ? $"{Name} loves bananas" : $"{Name} does not like bananas");
        }
        internal override void MakeSound()
        {
            Console.WriteLine("oo oo aa aa!");
        }
    }
}
