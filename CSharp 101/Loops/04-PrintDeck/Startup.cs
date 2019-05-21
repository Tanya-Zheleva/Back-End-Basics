namespace _04_PrintDeck
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                string cardType = i.ToString();

                if (i == 11)
                {
                    cardType = "Jack";
                }
                else if (i == 12)
                {
                    cardType = "Queen";
                }
                else if (i == 13)
                {
                    cardType = "King";
                }
                else if (i == 14)
                {
                    cardType = "Ace";
                }

                Console.WriteLine($"{cardType} of spades, {cardType} of clubs, {cardType} of hearts, {cardType} of diamonds");
            }
        }
    }
}
