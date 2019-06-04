namespace _08_NumberAsArray
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int[] lengths = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = lengths[0];
            int m = lengths[1];

            int[] firstNumber = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondNumber = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int minLen = n >= m ? m : n;
            int maxLen = n >= m ? n : m;
            int currentDigitSum = 0;
            int toAdd = 0;

            for (int i = 0; i < minLen; i++)
            {
                currentDigitSum = firstNumber[i] + secondNumber[i];
            }
        }
    }
}
