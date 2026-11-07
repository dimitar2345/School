using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal static class Cntrol
    {
        public static void PrintOptions()
        {
            Console.WriteLine("1.Bank account\n2.Checking account\n3.Savings account\n4.Exit");
        }
        public static void PrintBankOptions()
        {
            Console.WriteLine("1.Deposit\n2.Withrow\n3.Print all\n4.Exit");
        }
        public static void PrintOptionsFor()
        {
            Console.WriteLine("1.Create\n2.Delete\n3.List\n4.Deposit\n5.Withdrow\n6.Exit");
        }
    }
}
