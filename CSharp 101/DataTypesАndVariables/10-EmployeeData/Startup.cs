namespace _10_EmployeeData
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            string firstName = "Georgi";
            string lastName = "Georgiev";
            byte age = 22;
            char gender = 'm';
            long id = 8306112507;
            int employeeNumber = 27560560;

            Console.WriteLine($"{firstName} {lastName}, age: {age}, gender: {gender}");
            Console.WriteLine($"Personal ID: {id}, unique employee number: {employeeNumber}");
        }
    }
}
