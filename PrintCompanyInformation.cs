using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Company address: ");
        string companyAdres = Console.ReadLine();

        Console.Write("Phone number: ");
        double phoneNumb = double.Parse(Console.ReadLine());

        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();

        Console.Write("Web site: ");
        string webSite = Console.ReadLine();

        Console.Write("Manager first name: ");
        string mFirstName = Console.ReadLine();

        Console.Write("Manager last name: ");
        string mLastName = Console.ReadLine();

        Console.Write("Manager age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Manager phone: ");
        double mphone = double.Parse(Console.ReadLine());

        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}",
            companyName, companyAdres, phoneNumb, faxNumber, webSite, mFirstName, mLastName, age, mphone);




        //A company has name, address, phone number, fax number, web site and manager.
        //  The manager has first name, last name, age and a phone number.
        // Write a program that reads the information about a company and its manager and prints it back on the console.




    }
}

