namespace OnlineShop;

public class Footwear : Product
{
    private string size;
    private string style;

    public Footwear() : base()
    {
        System.Console.WriteLine("Enter the size of the product");
        size = Console.ReadLine();
        if (size == null)
            size = "";

        System.Console.WriteLine("Enter the style of the product");
        style = Console.ReadLine();
        if (style == null)
            style = "";
    }

    public override void PrintInfo()
    {
        System.Console.WriteLine($"{id} | {name} | {price}$ | {brand} | {size} | {style}");
    }

}
