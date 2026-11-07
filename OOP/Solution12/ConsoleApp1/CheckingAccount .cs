using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CheckingAccount : BackAccount
    {
        private double OverdraftLimit;
        public CheckingAccount() : base() 
        {
            string input = Console.ReadLine();
            double amount;
            if (double.TryParse(input, out amount) && amount >= 1)
            {
                OverdraftLimit = amount;
            }
        }
        public void Withdrow(double amount)
        {
            
            if (Balance == null)
            {
                Console.WriteLine("No money in account");
            }
            else if (!(amount <= OverdraftLimit))
            {
                Console.WriteLine("Amount to big to withdrow");
            }
            else
            {
                Balance -= amount;
            }
        }
    }
}
