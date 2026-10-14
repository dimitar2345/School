namespace Shop;

public class MainLogic
{
    private List<string> input;
    public MainLogic()
    {

        while (true)
        {
            input = Console.ReadLine().Split(" ").ToList();
            switch (input[0].ToLower())
            {
                case "sell":
                    {
                        if (LenghtCheck(3))
                            break;
                        double quantity = Input(input[2]);
                        if (quantity == -1)
                            break;
                        Control.Sell(input[1], quantity);
                    }
                    break;
                case "add":
                    {
                        if (LenghtCheck(5))
                            break;
                        double price = Input(input[3]);
                        double quantity = Input(input[4]);
                        Control.Add(input[1], input[2], price, quantity);
                    }
                    break;
                case "update":
                    {
                        if (LenghtCheck(3))
                            break;
                        double quantity = Input(input[2]);
                        Control.Update(input[1], quantity);
                    }
                    break;
                case "printa":
                    {
                        if (LenghtCheck(1))
                            break;
                        Control.PrintA();
                    }
                    break;
                case "printu":
                    {
                        if (LenghtCheck(1))
                            break;
                        Control.PrintU();
                    }
                    break;
                case "printd":
                    {
                        if (LenghtCheck(1))
                            break;
                        Control.PritnD();
                    }
                    break;
                case "calculate":
                    {
                        if (LenghtCheck(1))
                            break;
                        Control.Calculate();
                    }
                    break;
                case "close":
                    {
                        if (LenghtCheck(1))
                            break;
                        Environment.Exit(0);
                    }
                    break;
                default:
                    System.Console.WriteLine("Invalid input try again");
                    break;
            }
        }
    }
    private double Input(string input)
    {
        double output;
        if (input != null && double.TryParse(input, out output) && output! >= 0)
        {
            return output;
        }
        else
        {
            System.Console.WriteLine("Invalid input");
            return -1;
        }
    }
    private bool LenghtCheck(int lenght)
    {
        if (input.Count() != lenght )
        {
            System.Console.WriteLine("Invalid argument count");
            return true;
        }
        else
        {
            return false;
        }
    }
}
