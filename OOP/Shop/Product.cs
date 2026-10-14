namespace Shop;

public class Product
{
    private string name;
    private string barcode;
    private double price;
    private double quantity;
    public string Name { get { return name; } }
    public string Barcode { get { return barcode; } }
    public double Price { get { return price; } }
    public double Quantity { get { return quantity; } set { quantity = value; } }

    public Product(string name, string barcode, double price, double quantity)
    {
        this.name = name;
        this.barcode = barcode;
        this.price = price;
        this.quantity = quantity;
    }
    public void Print()
    {
        System.Console.WriteLine($"{name} ({barcode}) {price:F2} {quantity}");
    }
}
