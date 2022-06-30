using ConsoleDemo.Models;
using ConsoleDemo.Services;
using System;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            CustomerServices services = new CustomerServices(customer);

            while (true)
            {
                Console.WriteLine("1) Add New Customer \t 2) Quit");
                int choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 1)
                {
                    Customer newCustomer = new Customer();
                    Console.Write("Please Enter the Customer Id : ");
                    newCustomer.CustomerId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please Enter the Customer Name : ");
                    newCustomer.CustomerName = Console.ReadLine();
                    newCustomer.Balance = 1000;

                    try
                    {
                        services.AddCustomer(newCustomer);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Thanks for using our service!");
                    break;
                }
            }
        }
    }
}
