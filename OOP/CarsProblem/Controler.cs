using System.Data;

namespace CarsProblem;

public static class Controler
{
    public static int FindIndexOf(ref int[] arr, int num)
    {
        if (arr == null)
        {
            System.Console.WriteLine("Invalid input");
            return -1;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num)
            {
                return i;
            }
        }
        System.Console.WriteLine("Item not found");
        return -1;
    }
    public static int InputControl(string input, int restrain, bool control)
    {
        if (input == null || restrain == 0)
        {
            System.Console.WriteLine("Invalid input");
            return -1;
        }
        int result;
        if (int.TryParse(input, out result) && result != null && control ? result >= 0 : result >= 1 && result <= restrain)
        {
            return result;
        }
        else
        {
            System.Console.WriteLine("Invalid input");
            return -1;
        }
    }
    public static void Input(ref int num)
    {
        string input;
        int temp = 0;
        while (true)
        {
            input = Console.ReadLine();
            if (input == null)
            {
                System.Console.WriteLine("invalid input");
                continue;
            }
            temp = Controler.InputControl(input, 20, false);
            if (temp != -1)
            {
                break;
            }
        }
        num = temp;

    }
    public static int[] ObjectEntry(int interations)
    {
        int temp;
        int checksum = 0;
        int[] check;
        int[] result;
        List<int> added = new List<int>();
        string input;
        while (true)
        {
            check = new int[interations];
            for (int i = 0; i < interations; i++)
            {
                check[i] = i;
            }
            result = new int[interations];
            added = new List<int>();
            input = Console.ReadLine();
            List<string> strings = input.Split(" ").ToList();
            if (strings.Count() != interations)
            {
                System.Console.WriteLine("Invalid lenght");
                continue;
            }
            for (int i = 0; i < interations; i++)
            {
                string tempStr = strings[i];
                if (tempStr == null)
                {
                    System.Console.WriteLine("Input error");
                    break;
                }
                temp = InputControl(tempStr, interations - 1, true);
                if ((!check.Contains(temp) || added.Contains(temp) )&& temp != 0)
                {
                    System.Console.WriteLine($"{tempStr} is invalid");
                    break;
                }
                else
                {
                    added.Add(temp);
                    check[FindIndexOf(ref check,temp)] = -1;
                    result[i] = temp;
                    checksum++;
                }
            }
            if(checksum == interations)
            {
                break;
            }
        }
        System.Console.WriteLine("Press key to continue...");
        return result;
    }
}
