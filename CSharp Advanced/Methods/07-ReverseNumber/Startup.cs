namespace _07_ReverseNumber
{
    using System;
    using System.Text;

    public class Startup
    {
        public static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string reversed = ReverseNumber(number);

            Console.WriteLine(reversed);
        }

        private static string ReverseNumber(double number)
        {
            string numberAsString = number.ToString();
            StringBuilder result = new StringBuilder();

            for (int i = numberAsString.Length - 1; i >= 0; i--)
            {
                result.Append(numberAsString[i]);
            }

            return result.ToString();
        }
    }
}
