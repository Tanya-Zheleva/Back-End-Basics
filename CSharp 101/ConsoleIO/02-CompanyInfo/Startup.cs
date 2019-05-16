namespace _02_CompanyInfo
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            string companyAddress = Console.ReadLine();
            string companyPhone = Console.ReadLine();
            string fax = Console.ReadLine();
            string website = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            int managerAge = int.Parse(Console.ReadLine());
            string managerPhone = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(companyName);
            Console.WriteLine($"Address: {companyAddress}");
            Console.WriteLine($"Tel. {companyPhone}");

            string faxMessage = string.IsNullOrWhiteSpace(fax) ? "(no fax)" : fax;

            Console.WriteLine($"Fax: {faxMessage}");
            Console.WriteLine($"Web site: {website}");
            Console.WriteLine($"Manager: {managerFirstName} {managerLastName} (age: {managerAge}, tel. {managerPhone})");
        }
    }
}
