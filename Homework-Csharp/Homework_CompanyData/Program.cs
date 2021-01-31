using System;
using System.Text;

namespace Homework_CompanyData
{
    public class Program
    {
        static void Main(string[] args)
        {


            //A given company has name, address, phone number, fax number, web site and manager 
            //the manager has name, surname and phone number.
            //Write a program that read information about the company and its manager and then prints it on the console. 
            
            //Test data:
// ABCD S.r.o
//"Ivan Vazov" str.55, Sofia, BG
//+ 359 8888 8888 8888
//+ 359 8888 8888 8888
//www.abcd.com
//Ivan
//Ivanov
//+359 77777 88888 999



            Console.WriteLine("Enter Company Name");
            var company = Console.ReadLine();

            Console.WriteLine("Enter Company adress");
            var address = Console.ReadLine();

            Console.WriteLine("Enter Company phone");
            var phone = Console.ReadLine();

            Console.WriteLine("Enter Company fax");
            var fax = Console.ReadLine();

            Console.WriteLine("Enter Company website");
            var webSite = Console.ReadLine();

            Console.WriteLine("Enter Manager First Name");
            var managerName = Console.ReadLine();

            Console.WriteLine("Enter Manager sirname");
            var sirname = Console.ReadLine();

            Console.WriteLine("Enter Manager phone");
            var managerPhone = Console.ReadLine();

            var companyDetails = string.Format("Company: {0}\n " + "Address: {1}\n Phone: {2}," +
                "fax: {3}\nWebsite: {4}\nManager: {5} {6}\nPhone: {7}",
                company, address, phone, fax, webSite, managerName,sirname,phone);


            Console.WriteLine(companyDetails);
        }
    }
}
