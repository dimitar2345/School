namespace OnlineShop;

public class Clothing : Product
{
    private string size;
    private string material;

    public Clothing() : base()
    {
        System.Console.WriteLine("Enter the size of the product");
        size = Console.ReadLine();
        if (size == null)
            size = "";

        System.Console.WriteLine("Enter the material of the product");
        material = Console.ReadLine();
        if (material == null)
            material = "";
    }

    public override void PrintInfo()
    {
        System.Console.WriteLine($"{id} | {name} | {price}$ | {brand} | {size} | {material}");
    }
}
