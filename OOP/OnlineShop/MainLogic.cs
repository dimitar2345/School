using System.Collections;

namespace OnlineShop;

public class MainLogic
{
    public MainLogic()
    {
        while (true)
        {
            System.Console.WriteLine($"1.Add\n2.Print All");

            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    System.Console.WriteLine("1.Add footwear\n2.Add electronics\n3.Add clothing");
                    input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            OnlineStore.AddProduct(new Footwear());
                            break;
                        case "2":
                            OnlineStore.AddProduct(new Electronics());
                            break;
                        case "3":
                            OnlineStore.AddProduct(new Clothing());
                            break;
                    }
                    break;
                case "2":
                    OnlineStore.PrintAll();
                    break;
                default:
                    System.Console.WriteLine("Invalid inpt try again");
                    break;
            }
        }
    }
}
