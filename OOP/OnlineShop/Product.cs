namespace OnlineShop;

public abstract class Product
{
    protected string id;
    protected string name;
    protected double price;
    protected string brand;
    protected Product()
    {
        id = Security.IdGenerate();
        System.Console.WriteLine("Enter the name of the product");
        name = Console.ReadLine();
        if (name == null)
            name = "";
        while (true)
        {
            System.Console.WriteLine("Enter the price");
            string input = Console.ReadLine();
            double output;
            if (input != null && double.TryParse(input, out output) && output >= 0)
            {
                price = Math.Round(output, 2);
                break;
            }
            else
            {
                System.Console.WriteLine("Invalid try again");
            }
        }
        System.Console.WriteLine("Enter the brand of the product");
        brand = Console.ReadLine();
        if (brand == null)
            brand = "";

    }
    public abstract void PrintInfo();
}
