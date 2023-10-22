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
        public Monkey(string race = "monkey", string name = "Bill", string colour = "pink", string legs = "7", string fur = "long", bool canClimb = false) 
            : base(race, name, colour, legs, fur)
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
            Console.WriteLine("they prefer the jungle");
        }
        internal override void MakeSound()
        {
            Console.WriteLine("oo oo aa aa!");
        }
    }

    internal class Gorilla : Monkey
    {
        private bool IsBig { get; }
        public Gorilla(string race = "gorilla", string name = "Arnold", string colour = "black", string legs = "2", string fur = "short", bool canClimb = true, bool isBig = true) 
            : base(race, name, colour, legs, fur)
        {
            CanClimb = canClimb;
            IsBig = isBig;
        }
        //overriding the method from monkey and adds in the unique property.
        internal override void AnimalStats()
        {
            base.AnimalStats();
            Console.WriteLine(IsBig ? "He's a big gorilla" : "He's a small gorilla");
        }
        //mr gorilla wants his own sound
        internal override void MakeSound()
        {
            Console.WriteLine("-slaps chest-");
        }
    }

    internal class Macaque : Monkey
    {
        private bool LikesBananas { get; }
        public Macaque(string race = "macaque", string name = "Sylvester", string colour = "white", string legs = "2", string fur = "flat", bool canClimb = false, bool likesBananas = true) 
            : base(race, name, colour, legs, fur)
        {
            CanClimb = canClimb;
            LikesBananas = likesBananas;
        }
        internal override void AnimalStats()
        {
            base.AnimalStats();
            Console.WriteLine(LikesBananas ? "He loves bananas" : "He does not like bananas");
        }
    }
}
