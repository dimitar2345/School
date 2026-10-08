namespace Bank;

public class MainLogic
{
    public MainLogic()
    {
        string input;
        while (true)
        {
            input = Console.ReadLine().ToLower();

            switch (input)
            {
                case "deposit":
                    {
                        System.Console.WriteLine("How mutchmony do you want to deposit");
                        int id = CheckInt();
                        double amount = CheckDouble();
                        if (amount == -1 || id == -1)
                            break;
                        else
                            BankAccount.Deposit(id, amount);
                    }
                    break;
                case "withdraw":
                    {
                        System.Console.WriteLine("How mutch mony do you want to withdraw");
                        int id = CheckInt();
                        double amount = CheckDouble();
                        if (amount == -1 || id == -1)
                            break;
                        else
                            BankAccount.Withdraw(id, amount);
                    }
                    break;
                case "print":
                    BankAccount.Print();
                    break;
                case "add":
                    System.Console.WriteLine("Do you want to deposit money y/n");
                    input = Console.ReadLine().ToLower();
                    if (input == "y")
                    {
                        double amount = CheckDouble();
                        if (amount == -1)
                            break;
                        else
                            BankAccount.Add(amount);
                    }
                    else
                    {
                        BankAccount.Add(0);
                    }
                    break;
                case "close":
                    {
                        System.Console.WriteLine("Withch account do you want to close");
                        int id = CheckInt();
                        if (id == -1)
                            break;
                        else
                            BankAccount.Close(id);
                    }
                    break;
            }
        }
    }
    private double CheckDouble()
    {
        string input = Console.ReadLine();
        double output;
        if (input != null && double.TryParse(input, out output) && output > 0)
        {
            return output;
        }
        else
        {
            System.Console.WriteLine("Invalid input");
            return -1;
        }
    }
    private int CheckInt()
    {
        string input = Console.ReadLine();
        int output;
        if (input != null && int.TryParse(input, out output) && output > 0)
        {
            return output;
        }
        else
        {
            System.Console.WriteLine("Invalid input");
            return -1;
        }
    }
}
