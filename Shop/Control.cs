using System.Net.Quic;

namespace Shop;

public static class Control
{
    private static List<Product> products = new List<Product>();
    public static void Sell(string barcode, double quantity)
    {
        Product pr = FindProduct(barcode);
        if (pr != null)
        {
            if (quantity > pr.Quantity)
            {
                System.Console.WriteLine("Not enaugh quantity");
            }
            else
            {
                pr.Quantity -= quantity;
            }
        }
        else
        {
            System.Console.WriteLine("Product not found");
        }
    }
    public static void Add(string name, string barcode, double price, double quantity)
    {
        Product pr = FindProduct(barcode);
        if (pr == null)
        {
            products.Add(new Product(name, barcode, price, quantity));
        }
        else
        {
            System.Console.WriteLine("Produt already exists");
        }
    }
    public static void Update(string barcode, double quantity)
    {
        Product pr = FindProduct(barcode);
        if (pr != null)
        {
            pr.Quantity = quantity;
        }
        else
        {
            System.Console.WriteLine("Product not found");
        }
    }
    public static void PrintA()
    {
        SortProducts(1);
        PrintAll();
    }
    public static void PrintU()
    {
        SortProducts(1);
        foreach (Product pr in products)
        {
            if (pr.Quantity == 0)
            {
                pr.Print();
            }
        }
    }
    public static void PritnD()
    {
        SortProducts(2);
        PrintAll();
    }
    public static void Calculate()
    {
        double price = 0;
        foreach (Product pr in products)
        {
            price += pr.Price * pr.Quantity;
        }
        System.Console.WriteLine($"Value: {price:F2}");
    }
    public static Product FindProduct(string barcode)
    {
        foreach (Product product in products)
        {
            if (product.Barcode == barcode)
            {
                return product;
            }
        }
        return null;
    }
    private static void SortProducts(int option)
    {
        Product temp;
        int index;
        if (products.Count() > 0)
        {
            for (int i = 0; i < products.Count() - 1; i++)
            {
                index = i;
                for (int j = i; j < products.Count(); j++)
                {
                    if (option == 1)
                    {
                        if (String.Compare(products[index].Name, products[j].Name) == 1)
                        {
                            index = j;
                        }
                    }
                    else
                    {
                        if (products[index].Quantity < products[j].Quantity)
                        {
                            index = j;
                        }
                    }
                }
                if (index != i)
                {
                    temp = products[i];
                    products[i] = products[index];
                    products[index] = temp;
                }
            }
        }
    }
    private static void PrintAll()
    {
        foreach (Product product in products)
        {
            product.Print();
        }
    }
}
