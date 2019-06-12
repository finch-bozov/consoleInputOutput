using System;

namespace companyInformation
{
    class companyInformation
    {
        static void Main(string[] args)
        {
            Console.Write("What is the name of your company: ");
            string companyName = Console.ReadLine();
            Console.Write("What is the address of your company: ");
            string companyAddress = Console.ReadLine();
            Console.Write("What is your phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("What is your fax number: ");
            string faxNumber = Console.ReadLine();
            Console.Write("What is your website: ");
            string webSite = Console.ReadLine();
            Console.Write("What is the first name of the manager: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("What is the last name of the manager: ");
            string managerLastName = Console.ReadLine();
            Console.Write("How old is the manager: ");
            int managerAge = int.Parse(Console.ReadLine());
            Console.Write("What is the phone number of the manager: ");
            string managerPhoneNumber = Console.ReadLine();
            Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7}, tel. {8})",
            companyName, companyAddress, phoneNumber, faxNumber, webSite, managerFirstName, managerLastName, managerAge, managerPhoneNumber);
        }
    }
}
