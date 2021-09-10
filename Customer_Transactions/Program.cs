using System;

namespace Customer_Transactions
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.FirstName = "Ahmet";
            customer1.LastName = "Balkı";
            customer1.CustomerNo = "11";

            Customer customer2 = new Customer();
            customer2.FirstName = "Ezel";
            customer2.LastName = "Bayraktar";
            customer2.CustomerNo = "23";

            Customer customer3 = new Customer();
            customer3.FirstName = "Han";
            customer3.LastName = "Yıldız";
            customer3.CustomerNo = "52";

            Customer customer4 = new Customer();
            customer4.FirstName = "Burcu";
            customer4.LastName = "Kızıl";
            customer4.CustomerNo = "78";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.List(customers);
            customerManager.Add(customer4);
            customerManager.Delete(customer2);
        }
    }
}
