using System;

namespace CarsProblem;

internal class Problem
{
    public static void Main(String[] args)
    {
        List<object> container = new List<object>();
        int T = 0;
        int N = 0;
        Controler.Input(ref T);
        for (int i = 0; i < T; i++)
        {
            Controler.Input(ref N);
            container.Add(new MainLogic(Controler.ObjectEntry(N)));
        }
        foreach(MainLogic obj in container)
        {
            obj.Print();
        }
    }
}