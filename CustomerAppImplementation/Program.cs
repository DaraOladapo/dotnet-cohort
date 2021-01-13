using CustomerApp;
using System;
using System.Collections.Generic;

namespace CustomerAppImplementation
{
    class Program
    {
        private static ILogger logger;
        public Program(ILogger _logger)
        {
            logger = _logger;
        }
        static void Main(string[] args)
        {
            Customer normalCustomer = new Customer(logger);
            Console.WriteLine(normalCustomer.GetDiscount(5000));

            RegularCustomer regularCustomer = new RegularCustomer();
            Console.WriteLine(regularCustomer.GetDiscount(5000));
            Console.WriteLine(regularCustomer.GetBalance());

            PrimeCustomer primeCustomer = new PrimeCustomer();
            Console.WriteLine(primeCustomer.GetDiscount(5000));
            Console.WriteLine(primeCustomer.GetBalance());

            GuestCustomer guestCustomer = new GuestCustomer();
            Console.WriteLine(guestCustomer.GetDiscount(5000));

            List<Customer> customers = new List<Customer>();
            customers.Add(normalCustomer);
            customers.Add(regularCustomer);
            customers.Add(primeCustomer);
            //customers.Add(guestCustomer);
            foreach (var customer in customers)
            {
                customer.Add();
            }

            Customer thisCustomer = new Customer(logger);
        }
    }
}