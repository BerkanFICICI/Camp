using System;

namespace constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Anna";
            customer1.LastName = "Frost";
            customer1.City = "Los Angles";

            Customer customer2 = new Customer() {Id = 2, FirstName = "Burak", LastName = "Duran", City = "Tekirdağ" };

            //Constructor
            Customer customer3 = new Customer(3, "Emre", "Aka", "Tekirdağ");
            
            //Print on console.
            Console.WriteLine(customer1.FirstName);
            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer3.FirstName); 
        }
    }
}

class Customer 
{
    public Customer()
    {

    }
    public Customer(int id, string firstName, string lastName, string city)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}