using System.Formats.Asn1;
using System.Runtime.InteropServices;

namespace Bank;

public static class BankAccount
{
    private static List<Bank> accounts = new List<Bank>();

    public static void Add(double amount)
    {
        Random random = new Random();
        int id = random.Next(1000, 9999);
        accounts.Add(new Bank(id, amount));
        string a = amount == null ? "0" : $"{amount:F2}";
        System.Console.WriteLine($"Account created {id} with balance {a}");
    }

    public static void Close(int id)
    {
        Bank account = FindAccount(id);
        if (account != null)
        {
            accounts.Remove(account);
        }
        else
        {
            System.Console.WriteLine("This account is not real");
        }
    }
    public static void Deposit(int id, double amount)
    {
        Bank account = FindAccount(id);
        if (account == null)
            System.Console.WriteLine("This account is not real");
        else
            account.Deposit(amount);
    }
    public static void Withdraw(int id, double amount)
    {
        Bank account = FindAccount(id);
        if (account == null)
        {
            System.Console.WriteLine("This account is not real");
        }
        else if (account.Balance < amount)
        {
            System.Console.WriteLine("Not enaugh money in account");
        }
        else
        {
            account.Withdraw(amount);
        }
    }
    public static void Print()
    {
        foreach (Bank account in accounts)
        {
            Console.WriteLine(account.ToString());
        }
    }
    public static Bank FindAccount(int id)
    {
        foreach (Bank account in accounts)
        {
            if (account.Id == id)
            {
                return account;
            }
        }
        return null;
    }
}
