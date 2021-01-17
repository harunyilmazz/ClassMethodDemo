using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public static void Add(Customer customer)
        {
            Console.WriteLine("Id: "+customer.Id +"\n"+ customer.Name +" "+ customer.Surname +" added!");
        }

        public static void Update(Customer customer)
        {
            Console.WriteLine("Id: " + customer.Id + "\n" + customer.Name + " " + customer.Surname + " updated!");
        }

        public static void Delete(Customer customer)
        {
            Console.WriteLine("Id: " + customer.Id + "\n" + customer.Name + " " + customer.Surname + " deleted!");
        }
    }
}
