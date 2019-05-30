namespace _05_SortByStringLength
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter strings in array count: ");
            int stringsCount = int.Parse(Console.ReadLine());
            string[] strings = new string[stringsCount];

            for (int i = 0; i < stringsCount; i++)
            {
                Console.Write($"Enter string {i + 1} content: ");
                strings[i] = Console.ReadLine();
            }

            for (int i = 0; i < stringsCount - 1; i++)
            {
                for (int j = i + 1; j < stringsCount; j++)
                {
                    if (strings[i].Length > strings[j].Length)
                    {
                        string old = strings[i];
                        strings[i] = strings[j];
                        strings[j] = old;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", strings));
        }
    }
}
