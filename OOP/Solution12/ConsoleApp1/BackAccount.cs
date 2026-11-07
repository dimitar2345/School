using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BackAccount
    {
        Queue<string> Log = new Queue<string>(100);
        public BackAccount()
        {
            Random rand = new Random();

            AccountId = rand.Next(12312344,12312454).ToString();
            Owner = Console.ReadLine();
            Balance = 0;
        }
        protected string AccountId;
        protected string Owner;
        protected double Balance;

        public void Deposit(double amount)
        {
            if (Balance == null)
            {
                Balance = amount;
            }
            else
            {
                Balance += amount;
            }
        }
        public void Withdrow(double amount)
        {
            if (Balance == null)
            {
                Console.WriteLine("No money in account");
            }
            else if(!(amount <= Balance))
            {
                Console.WriteLine("Amount to big to withdrow");

            }
            else
            {
                Balance -= amount;
            }
        }
        public void DisplayAccountInfo()
        {
            Console.WriteLine($"{AccountId} | {Owner} | {Balance.ToString("F2")}$");
        }

    }
}
