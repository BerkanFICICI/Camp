using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Emre Aka
            RealCustomer customer1 = new RealCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.CustomerName = "Emre";
            customer1.CustomerLastName = "Aka";
            customer1.SocialSecurityNo = "123456789";
            //Kodlama.io
            LegalCustomer customer2 = new LegalCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "51234";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "123634213";
            //Real customer - Legal costomer
            //SOLID

            Customer customer3 = new RealCustomer();
            Customer customer4 = new LegalCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
