namespace Domashno;

using System.Threading;

public class Manger
{
    private bool DoExit = false;
    private static List<Lake> lakes = new List<Lake>();

    public Manger()
    {
        while (true)
        {
            UserInputOutput();
            System.Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
            if (DoExit)
            {
                System.Console.WriteLine("Goodbye!");
                Environment.Exit(0);

            }
        }
    }

    private void UserInputOutput()
    {
        PrintOptions();
        Options();

    }
    private static void PrintOptions()
    {
        System.Console.WriteLine("Choose an option:");
        System.Console.WriteLine(
            "1.Print all lakes\n" +
            "2.Add lake\n" +
            "3.Remove lake\n" +
            "4.Print Animals\n" +
            "5.Print log\n" +
            "6.Exit\n"
        );
    }
    private void Options()
    {
        switch (Input(6))
        {
            case 1:
                if (lakes.Count == 0)
                {
                    System.Console.WriteLine("There are no lakes!");
                    break;
                }
                ListLakes();
                break;
            case 2:
                lakes.Add(new Lake($"Lake{lakes.Count()}"));
                break;
            case 3:
                if (lakes.Count == 0)
                {
                    System.Console.WriteLine("There are no lakes to be removed!");
                    break;
                }
                System.Console.WriteLine("Choose a lake to remove");
                ListLakes();
                int index = Input(lakes.Count());
                if (index == -1)
                    break;
                System.Console.WriteLine($"Removed {lakes[index - 1].Name}");
                lakes[index - 1].Flag = false;
                lakes.RemoveAt(index - 1);
                break;
            case 4:
                foreach (Lake lake in lakes)
                {
                    System.Console.WriteLine();
                    lake.PrintLake();
                    System.Console.WriteLine();
                }
                break;
            case 5:
                Log.FlushLog();
                Log.DoQuit = false;
                break;
            case 6:
                DoExit = true;
                break;


        }
    }
    private void ListLakes()
    {
        for (int i = 0; i < lakes.Count(); i++)
        {
            System.Console.WriteLine($"{i + 1}.{lakes[i].Name}");
        }
    }
    private static int Input(int range)
    {
        int index;
        string input;

        while (true)
        {
            input = System.Console.ReadLine();
            if (input == "exit")
            {
                return -1;
            }
            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out index) && index > 0 && index <= range)
            {
                return index;
            }
            else
            {
                System.Console.WriteLine("Invalid input. Try again!");
            }
        }
    }
}
