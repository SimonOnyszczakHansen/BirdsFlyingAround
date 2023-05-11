namespace BirdsFlyingAround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eagle eagle = new Eagle("Gynther", "Han");
            Console.WriteLine(eagle.Hunt());

            Parrot prt = new Parrot("Simon", "hun");
            Console.WriteLine(prt.Fly());

            Penguin pgn = new Penguin("KKJHSD", "han");
            Console.WriteLine(pgn.DiveUnderWater());

            Duck duck = new Duck("HAJSDH", "han");
            Console.WriteLine(duck.Fly());

            Ostrich ostr = new Ostrich("SJKHD", "hun");
            Console.WriteLine(ostr.Eat());

            Console.ReadLine();
        }
    }
}