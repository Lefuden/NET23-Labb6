//Daniel Frykman .NET23
namespace Labb6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a whole bunch of animals being created and then calling various methods to output data
            Fish myFish = new("Nemo", "white and orange","clownfish", 5, 1, false);
            myFish.AllInfo();
            Console.WriteLine();

            Bird myBird = new("Will", "black","crow", 22, 8, 2, false);
            myBird.AllInfo();
            Console.WriteLine();

            Monkey myMonkey = new("Karl", "orange", "orangutang", 120, 44, 2, "bushy", true);
            myMonkey.AllInfo();
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