using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class MainLogic
    {
        List<BackAccount> backAccounts = new List<BackAccount>();
        List<CheckingAccount> checkingAccounts = new List<CheckingAccount>();
        List<SavingsAccount> savingsAccounts = new List<SavingsAccount>();

        public MainLogic()
        {
            while (true)
            {
                Cntrol.PrintOptions();
                string input = Console.ReadLine();
                int option;
                if (int.TryParse(input, out option) && option >= 1 && option <= 4)
                {
                    if (option == 4)
                    {
                        Environment.Exit(0);
                        continue;
                    }
                    Cntrol.PrintOptionsFor();
                    input = Console.ReadLine();
                    int result;
                    if (int.TryParse(input, out result) && result >= 1 && result <= 6)
                    {
                        if (result == 6)
                        {
                            continue;
                        }
                    }
                    switch (option)
                    {
                        case 1:
                            switch (result)
                            {
                                case 1:
                                    backAccounts.Add(new BackAccount());
                                    break;
                                case 2:
                                    for (int i = 0; i < backAccounts.Count(); i++)
                                    {
                                        Console.Write(i + 1 + ".");
                                        backAccounts[i].DisplayAccountInfo();
                                        Console.WriteLine();
                                    }
                                    input = Console.ReadLine();
                                    if (int.TryParse(input, out result) && result >= 1 && result <= backAccounts.Count())
                                    {
                                        backAccounts.RemoveAt(result - 1);
                                    }
                                    break;
                                case 3:
                                    for (int i = 0; i < backAccounts.Count(); i++)
                                    {
                                        Console.Write(i + 1 + ".");
                                        backAccounts[i].DisplayAccountInfo();
                                        Console.WriteLine();
                                    }
                                    break;
                                case 4:
                                    for (int i = 0; i < backAccounts.Count(); i++)
                                    {
                                        Console.Write(i + 1 + ".");
                                        backAccounts[i].DisplayAccountInfo();
                                        Console.WriteLine();
                                    }
                                    input = Console.ReadLine();
                                    if (int.TryParse(input, out result) && result >= 1 && result <= backAccounts.Count())
                                    {
                                        input = Console.ReadLine();
                                        double amount;
                                        if (double.TryParse(input, out amount) && amount >= 1)
                                        {
                                            backAccounts[result].Deposit(amount);
                                        }
                                    }
                                    
                                    break;
                                case 5:
                                    for (int i = 0; i < backAccounts.Count(); i++)
                                    {
                                        Console.Write(i + 1 + ".");
                                        backAccounts[i].DisplayAccountInfo();
                                        Console.WriteLine();
                                    }
                                    input = Console.ReadLine();
                                    if (int.TryParse(input, out result) && result >= 1 && result <= backAccounts.Count())
                                    {
                                        input = Console.ReadLine();
                                        double amount;
                                        if (double.TryParse(input, out amount) && amount >= 1)
                                        {
                                            backAccounts[result].Withdrow(amount);
                                        }
                                    }
                                    break;

                            }
                            break;
                        case 2:
                            switch (result)
                            {
                                case 1:
                                    checkingAccounts.Add(new CheckingAccount());
                                    break;
                                case 2:
                                    for (int i = 0; i < checkingAccounts.Count(); i++)
                                    {
                                        Console.Write(i + 1 + ".");
                                        checkingAccounts[i].DisplayAccountInfo();
                                        Console.WriteLine();
                                    }
                                    input = Console.ReadLine();
                                    if (int.TryParse(input, out result) && result >= 1 && result <= checkingAccounts.Count())
                                    {
                                        checkingAccounts.RemoveAt(result - 1);
                                    }
                                    break;
                                case 3:
                                    for (int i = 0; i < checkingAccounts.Count(); i++)
                                    {
                                        Console.Write(i + 1 + ".");
                                        checkingAccounts[i].DisplayAccountInfo();
                                        Console.WriteLine();
                                    }
                                    break;
                                case 4:
                                    for (int i = 0; i < checkingAccounts.Count(); i++)
                                    {
                                        Console.Write(i + 1 + ".");
                                        checkingAccounts[i].DisplayAccountInfo();
                                        Console.WriteLine();
                                    }
                                    input = Console.ReadLine();
                                    if (int.TryParse(input, out result) && result >= 1 && result <= checkingAccounts.Count())
                                    {
                                        input = Console.ReadLine();
                                        double amount;
                                        if (double.TryParse(input, out amount) && amount >= 1)
                                        {
                                            checkingAccounts[result].Deposit(amount);
                                        }
                                    }

                                    break;
                                case 5:
                                    for (int i = 0; i < checkingAccounts.Count(); i++)
                                    {
                                        Console.Write(i + 1 + ".");
                                        checkingAccounts[i].DisplayAccountInfo();
                                        Console.WriteLine();
                                    }
                                    input = Console.ReadLine();
                                    if (int.TryParse(input, out result) && result >= 1 && result <= checkingAccounts.Count())
                                    {
                                        input = Console.ReadLine();
                                        double amount;
                                        if (double.TryParse(input, out amount) && amount >= 1)
                                        {
                                            checkingAccounts[result].Withdrow(amount);
                                        }
                                    }
                                    break;

                            }
                            break;
                        case 3:
                            switch (result)
                            {
                                case 1:
                                    savingsAccounts.Add(new SavingsAccount());
                                    break;
                                case 2:
                                    for (int i = 0; i < savingsAccounts.Count(); i++)
                                    {
                                        Console.Write(i + 1 + ".");
                                        savingsAccounts[i].DisplayAccountInfo();
                                        Console.WriteLine();
                                    }
                                    input = Console.ReadLine();
                                    if (int.TryParse(input, out result) && result >= 1 && result <= savingsAccounts.Count())
                                    {
                                        savingsAccounts.RemoveAt(result - 1);
                                    }
                                    break;
                                case 3:
                                    for (int i = 0; i < savingsAccounts.Count(); i++)
                                    {
                                        Console.Write(i + 1 + ".");
                                        savingsAccounts[i].DisplayAccountInfo();
                                        Console.WriteLine();
                                    }
                                    break;
                                case 4:
                                    for (int i = 0; i < savingsAccounts.Count(); i++)
                                    {
                                        Console.Write(i + 1 + ".");
                                        savingsAccounts[i].DisplayAccountInfo();
                                        Console.WriteLine();
                                    }
                                    input = Console.ReadLine();
                                    if (int.TryParse(input, out result) && result >= 1 && result <= savingsAccounts.Count())
                                    {
                                        input = Console.ReadLine();
                                        double amount;
                                        if (double.TryParse(input, out amount) && amount >= 1)
                                        {
                                            savingsAccounts[result].Deposit(amount);
                                        }
                                    }

                                    break;
                                case 5:
                                    for (int i = 0; i < savingsAccounts.Count(); i++)
                                    {
                                        Console.Write(i + 1 + ".");
                                        savingsAccounts[i].DisplayAccountInfo();
                                        Console.WriteLine();
                                    }
                                    input = Console.ReadLine();
                                    if (int.TryParse(input, out result) && result >= 1 && result <= savingsAccounts.Count())
                                    {
                                        input = Console.ReadLine();
                                        double amount;
                                        if (double.TryParse(input, out amount) && amount >= 1)
                                        {
                                            savingsAccounts[result].Withdrow(amount);
                                        }
                                    }
                                    break;
                            }
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
        }
    }
}
