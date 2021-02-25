using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            Customer customer1 = new Customer("John", "Smith", 51);
            Customer customer2 = new Customer("Helen", "Smith", 45);
            Customer customer3 = new Customer("Juliana", "Crain", 25);
            Customer customer4 = new Customer("Frank", "Frink", 27);

            customerManager.AddCustomer(customer1, customer2, customer3, customer4);
            
            customerManager.ListCustomers();
             
            customerManager.RemoveCustomer(customer3);
            
            customerManager.ListCustomers();
            
        }
    }
}
