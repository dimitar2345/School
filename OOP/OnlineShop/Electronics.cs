namespace OnlineShop;

public class Electronics : Product
{
    private int voltage;

    public Electronics() : base()
    {
        System.Console.WriteLine("Enter the voltage of the product");
        while (true)
        {
            System.Console.WriteLine("Enter the price");
            string input = Console.ReadLine();
            int output;
            if (input != null && int.TryParse(input, out output) && output > 0)
            {
                voltage = output;
                break;
            }
            else
            {
                System.Console.WriteLine("Invalid try again");
            }
        }

        
    }
    public override void PrintInfo()
    {
        System.Console.WriteLine($"{id} | {name} | {price}$ | {brand} | {voltage}V");
    }
}
