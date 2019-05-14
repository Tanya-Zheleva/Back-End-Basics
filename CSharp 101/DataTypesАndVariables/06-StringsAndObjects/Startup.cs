namespace _06_StringsAndObjects
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            string valueOne = "Hello";
            string valueTwo = "World";

            object concated = valueOne +  " " + valueTwo;
            string valueThree = (string)concated;

            Console.WriteLine(valueThree);
        }
    }
}
