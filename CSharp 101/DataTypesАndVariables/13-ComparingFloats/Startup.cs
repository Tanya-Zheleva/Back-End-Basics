namespace _13_ComparingFloats
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first floating-point number: ");
            double first = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second floating-point number: ");
            double second = double.Parse(Console.ReadLine());

            double eps = 0.000001;
            double diff = Math.Abs(first - second);
            bool areEqual = diff < eps;

            Console.WriteLine(areEqual);
        }
    }
}
