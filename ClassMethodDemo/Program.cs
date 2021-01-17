using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 123;
            customer1.Name = "John";
            customer1.Surname = "Doe";
            customer1.TotalMonthlyExpenditure = 3506.19;

            Customer customer2 = new Customer();
            customer2.Id = 124;
            customer2.Name = "Max";
            customer2.Surname = "Lawyer";
            customer2.TotalMonthlyExpenditure = 8567.45;

            Customer customer3 = new Customer();
            customer3.Id = 125;
            customer3.Name = "Elizabeth";
            customer3.Surname = "Staller";
            customer3.TotalMonthlyExpenditure = 12678.87;

            Console.WriteLine("*************************************");
            Console.WriteLine("** Welcome to HARBANK Worker Panel **");
            Console.WriteLine("*************************************\n\n");
            Console.WriteLine("************* CUSTOMERS *************\n");

            Customer[] customers = new Customer[] { customer1,customer2,customer3 };

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Id : " + customer.Id +"\nName : "+ customer.Name +"\nSurname : "+ customer.Surname +"\nTotal Monthly Expenditure : "+ customer.TotalMonthlyExpenditure);
                Console.WriteLine("------------------------------\n");
            }

            Console.WriteLine("\n******** CUSTOMER ADD PANEL ********\n");

            CustomerManager.Add(customer1);
            Console.WriteLine("------------------------------");
            CustomerManager.Add(customer2);
            Console.WriteLine("------------------------------");
            CustomerManager.Add(customer3);
            Console.WriteLine("\n\n");

            Console.WriteLine("******* CUSTOMER UPDATE PANEL *******\n");

            CustomerManager.Update(customer1);
            Console.WriteLine("------------------------------");
            CustomerManager.Update(customer2);
            Console.WriteLine("------------------------------");
            CustomerManager.Update(customer3);
            Console.WriteLine("\n\n");

            Console.WriteLine("******* CUSTOMER DELETE PANEL *******\n");

            CustomerManager.Delete(customer1);
            Console.WriteLine("------------------------------");
            CustomerManager.Delete(customer2);
            Console.WriteLine("------------------------------");
            CustomerManager.Delete(customer3);
        }
    }
}
