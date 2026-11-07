using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SavingsAccount : BackAccount
    {
        private double InterestRate;

        public SavingsAccount() : base()
        {
            string input = Console.ReadLine();
            double amount;
            if (double.TryParse(input, out amount) && amount >= 0 && amount <=100)
            {
                InterestRate = amount;
            }
        }
        public void AccrueInterest()
        {
            Balance += InterestRate / 100 * Balance;
        }

    }
}
