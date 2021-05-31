using System;

namespace Day3Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Sufyan";
            customer1.LastName = "Taskin";
            customer1.Age = 25;
            customer1.NationalIdentity = "12345678910";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Engin";
            customer2.LastName = "Demiroğ";
            customer2.Age = 30;
            customer2.NationalIdentity = "2345678911";

            CustomerManager manager = new CustomerManager();
            manager.Add(customer1);
            manager.Update(customer2);
        }
    }
}