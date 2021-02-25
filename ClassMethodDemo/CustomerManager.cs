using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        private List<Customer> customerList = new List<Customer>();

        public List<Customer> CustomerList //customerList getter
        {
            get { return customerList; }
        }

        public void AddCustomer(params Customer[] customer)//Customer adder method using params
        {
            foreach (var item in customer)
            {
                customerList.Add(item);
            }
        }

        public void RemoveCustomer(Customer customer)//Customer remover
        {
            customerList.Remove(customer);
        }

        public void ListCustomers()//Customer lister
        {
            Console.WriteLine("Name - Last Name - Age - Number of Orders");
            foreach (var customer in customerList)
            {
                Console.WriteLine(customer.CustomerName + " " + customer.CustomerLastName + " "
                    + customer.CustomerAge + " " + customer.CustomerNumberOfOrders);

            }
        }
    }
}
