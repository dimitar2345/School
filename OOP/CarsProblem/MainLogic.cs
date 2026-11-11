namespace CarsProblem;

public class MainLogic
{
    private int[] cars;
    private int time;
    public int Time { get { return time; } }
    List<int> unsorted = new List<int>();
    public MainLogic(int[] cars)
    {
        this.cars = cars;
        Calculate();
    }
    private void Calculate()
    {
        for (int i = 0; i < cars.Length; i++)
        {
            if (cars[i] != i && cars[i] != 0)
            {
                unsorted.Add(cars[i]);
            }
        }
        while (!CheckIfSorted())
        {
            if (unsorted.Count == 0)
                return;
            int zeroIndex = Controler.FindIndexOf(ref cars, 0);
            if (zeroIndex != 0)
            {
                int lastIndex = zeroIndex;
                while (Controler.FindIndexOf(ref cars, 0) != 0)
                {
                    int num = Controler.FindIndexOf(ref cars, lastIndex);
                    cars[lastIndex] = cars[num];
                    cars[num] = 0;
                    time += 10;
                    unsorted.Remove(cars[lastIndex]);
                    lastIndex = num;
                }
            }
            else
            {

                int numIndex = Controler.FindIndexOf(ref cars, unsorted[0]);
                cars[0] = cars[numIndex];
                cars[numIndex] = 0;
                time += 10;

            }
        }

    }
    public void Print()
    {
        foreach (int i in cars)
        {
            System.Console.Write(i == cars.Length - 1 ? i : i + ", ");
        }
        System.Console.WriteLine();
        System.Console.WriteLine();
        System.Console.WriteLine(time);
    }
    private bool CheckIfSorted()
    {
        int temp = -1;
        foreach (int i in cars)
        {
            if (temp < i)
                temp = i;
            else
                return false;
        }
        return true;
    }
}
