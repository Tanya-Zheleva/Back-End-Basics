namespace _11_BankAccountData
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            string firstName = "Georgi";
            string middleName = "Petrov";
            string lastName = "Georgiev";
            decimal amountOfMoney = 648476.99m;
            string bankName = "Iron Bank";
            string iban = "WE56 0483 5012 3456 7800 9";
            long firstCardNumber = 5555555555554444;
            long secondCardNumber = 4111111111111111;
            long thirdCardNumner = 4012888888881881;

            Console.WriteLine($"User: {firstName} {middleName} {lastName}");
            Console.WriteLine($"Bank: {bankName}, available {amountOfMoney}$");
            Console.WriteLine($"IBAN: {iban}");
            Console.WriteLine($"First credit card number: {firstCardNumber}");
            Console.WriteLine($"Second credit card number: {secondCardNumber}");
            Console.WriteLine($"Third credit card number: {thirdCardNumner}");
        }
    }
}
