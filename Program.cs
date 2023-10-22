//Daniel Frykman .NET23
namespace Labb6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fish myFish = new("clownfish", "Nemo", "white and orange", "no", "no", false);
            myFish.AnimalStats();
            myFish.MakeSound();
            myFish.Swim();
            myFish.LivesWhere();
            Console.WriteLine();

            Bird myBird = new("crow", "Will", "black", "2", "no", false);
            myBird.AnimalStats();
            myBird.MakeSound();
            myBird.Fly();
            myBird.LivesWhere();
            Console.WriteLine();

            Monkey myMonkey = new("orangutang", "Karl", "orange", "2", "bushy", true);
            myMonkey.AnimalStats();
            myMonkey.MakeSound();
            myMonkey.Behaviour();
            myMonkey.LivesWhere();
            Console.WriteLine();

            Gorilla myGorilla = new();
            myGorilla.AnimalStats();
            myGorilla.MakeSound();
            Console.WriteLine();

            Macaque myMacaque = new();
            myMacaque.AnimalStats();
            myMacaque.MakeSound();
        }
    }
}