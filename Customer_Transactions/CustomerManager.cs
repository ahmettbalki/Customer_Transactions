using System;
using System.Collections.Generic;
using System.Text;

namespace Customer_Transactions
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer added.");
            Console.WriteLine("First Name : " + customer.FirstName + ". Last Name : " + customer.LastName + ". No: " + customer.CustomerNo);
            Console.WriteLine("-------------------------");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleted.");
            Console.WriteLine("First Name : " + customer.FirstName + ". Last Name : " + customer.LastName + ". No: " + customer.CustomerNo);
            Console.WriteLine("-------------------------");
        }
        public void List(Customer[] customer)
        {
            Console.WriteLine("Customers listed.");

            foreach (var cust in customer)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("First Name : " + cust.FirstName);
                Console.WriteLine("Last Name : " + cust.LastName);
                Console.WriteLine("Customer No : " + cust.CustomerNo);
                Console.WriteLine("-----------------------");
            }
        }
    }
}
