using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    class Customer
    {
        //Customer properties
        private int customerID;
        private string customerName;
        private string customerLastName;
        private int customerAge;
        private int customerNumberOfOrders;

        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public int CustomerAge { get; set; }
        public int CustomerNumberOfOrders { get; set; }

        public Customer() //Empty constructor
        {

        }

        public Customer(string name, string lastName, int age)//Regular constructor
        {
            CustomerName = name;
            CustomerLastName = lastName;
            CustomerAge = age;
        }
        

    }
}
