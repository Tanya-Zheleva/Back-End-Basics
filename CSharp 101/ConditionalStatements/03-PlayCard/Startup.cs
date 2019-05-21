namespace _03_PlayCard
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            string card = Console.ReadLine();

            switch (card)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "10":
                case "J":
                case "Q":
                case "K":
                case "A":
                    Console.WriteLine($"yes {card}");
                    break;
                default:
                    Console.WriteLine($"no {card}");
                    break;
            }
        }
    }
}
