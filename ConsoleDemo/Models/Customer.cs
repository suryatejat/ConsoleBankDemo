using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        /*public int AccountNumber { get; set; }
        public string IFSC { get; set; }*/
        public decimal Balance { get; set; }
        /*public string BankName { get; set; }*/
    }
}
