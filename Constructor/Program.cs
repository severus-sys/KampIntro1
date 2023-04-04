using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {   

            Customer customer1 = new Customer() { Id=1,FirstName="Engin",
                LastName="Demiröğ",City="Ankara"};

            Customer customer2 = new Customer(2,"Derin","Demiröğ","Ankara");

            Customer customer3 = new Customer();
            customer3.Id = 3;


            
        }
    }
    class Customer
    {
        //default constructor
        public Customer()
        {
            
        }

       
        public Customer(int id,string firstName,string lastName,string city)
        {
            Console.WriteLine("Yapıcı Blok");
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
}