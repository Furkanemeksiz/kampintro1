using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirsName = "engin", LastName = "demiroğ", City = "ankara" };

            Customer customer2 = new Customer(2, "derin", "demiroğ", "ankara");



        }
    }
    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id,string firstName,string lastName,string city)
        {
            Id = id;
            FirsName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirsName  { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }





}
