namespace Stadion;

public static class QualityControl
{
    public static void PrintMenu()
    {
        System.Console.WriteLine("1.Add stedium\n" +
            "2.List Stadins\n" +
            "3.Remove Stadion\n" +
            "4.Exit"
            );
    }
    public static int Input(int range)
    {
        int output;
        string input;
        while (true)
        {
            input = Console.ReadLine();

            if (input != null && int.TryParse(input, out output) && ((range == 0) ? true : (output <= range))&& output >= 1)
            {
                return output;
            }
            else
            {
                System.Console.WriteLine("Invalid input");
            }
        }
    }
}
