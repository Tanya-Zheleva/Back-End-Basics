namespace _03_VariableHexadecimalFormat
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int decimalValue = 254;
            string hexValue = decimalValue.ToString("X");

            Console.WriteLine(hexValue);
        }
    }
}
