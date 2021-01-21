using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //We added some customers to our 'Costumer Class.'
            //Müşreti sınıfımıza müşteriler ekledik.
            Customer customer1 = new Customer();
            customer1.Id = 01;
            customer1.Name = "Anna";
            customer1.Soyad = "Brown";
            customer1.SocialNumber = "158159785";
            customer1.Balance = 5000;

            Customer customer2 = new Customer();
            customer2.Id = 02;
            customer2.Name = "Emre";
            customer2.Soyad = "Aka";
            customer2.SocialNumber = "987216489";
            customer2.Balance = 15000;

            Customer customer3 = new Customer();
            customer3.Id = 03;
            customer3.Name = "Burak";
            customer3.Soyad = "Duran";
            customer3.SocialNumber = "452387982";
            customer3.Balance = 8950;
            //After this line is where we run our methods which is assigned by us.
            //Bu satırdan sonraki satırlar metotlarımızı çağırdığımız yer olacak.
            CustomerManagement customerManagement = new CustomerManagement();
            Console.WriteLine(customerManagement.Add(customer1));
            Console.WriteLine(customerManagement.Add(customer2)); 
            Console.WriteLine(customerManagement.Add(customer3));
            Console.WriteLine(customerManagement.Remove(customer1));
            Console.WriteLine(customerManagement.Remove(customer2));
            Console.WriteLine(customerManagement.Remove(customer3));
            Console.WriteLine(customerManagement.Balance(customer1));
            Console.WriteLine(customerManagement.Balance(customer2));
            Console.WriteLine(customerManagement.Balance(customer3));
        }
    }
}
