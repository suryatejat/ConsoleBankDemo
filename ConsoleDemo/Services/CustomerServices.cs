using ConsoleDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo.Services
{
    public class CustomerServices
    {
        private Customer Customer;

        private List<Customer> Customers = new List<Customer>();
        public CustomerServices(Customer customer)
        {
            this.Customer = customer;
        }

        /*public decimal GetBalance(int customerId)
        {
            try
            {

            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }*/

        public void AddCustomer(Customer newCustomer)
        {
            try
            {
                Customers.Add(newCustomer);
                for(int i = 0; i < Customers.Count(); i++)
                {
                    Console.WriteLine(Customers[i].CustomerId + " " + Customers[i].CustomerName);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
