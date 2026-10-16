namespace Stadion;

public class Stadion
{
    private int r;
    private double area;
    private double perimetar;
    private double pricePerSquare;
    private double fencePrice;
    public double Area { get { return area; } }
    public double PricePerSquare { get { return pricePerSquare; } }
    public double FencePrice { get { return fencePrice; } }

    public Stadion(int r)
    {
        this.r = r;
        perimetar = Math.Round(CalculetePerimetar(), 2);
        area = Math.Round(CalculeteArea(), 2);
        System.Console.WriteLine("Perimetar: " + perimetar + "\nArea: " + area);
        pricePerSquare = Math.Round(QualityControl.Input(0) * area, 2);
        fencePrice = Math.Round(QualityControl.Input(0) * perimetar, 2);
    }

    private double CalculeteArea()
    {
        return 4 * r * 2 * r + Math.PI * r * r;
    }
    private double CalculetePerimetar()
    {
        return 4 * r * 2 + Math.PI * r * 2;
    }
    public void Print()
    {
        System.Console.WriteLine($"This stadion area is {area} \nits perimetar is {perimetar} \nthe price for fences are {fencePrice}\nthe price for the nastilka is {pricePerSquare}");
    }

}
