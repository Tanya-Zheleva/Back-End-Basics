namespace _12_IndexOfLetters
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] letters = new char[26];

            for (int i = 0; i < letters.Length; i++)
            {
                letters[i] = (char)(97 + i);
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (letters.Contains(input[i]))
                {
                    Console.WriteLine(input[i] - 97);
                }
            }
        }
    }
}
