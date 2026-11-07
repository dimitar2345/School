namespace OnlineShop;

public static class OnlineStore
{
    private static List<Product> objects = new List<Product>();

    public static void AddProduct(Product product)
    {
        objects.Add(product);
    }
    public static void PrintAll()
    {
        foreach(var obj in objects)
        {
            obj.PrintInfo();
        }
    }
}
