using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

namespace Domashno;

public class Lake
{
    private static string[] specees = new string[]
    {
        "fish",
        "frog",
        "crocodile"
    };
    RandomEvents randomEvents = new RandomEvents();
    private bool FirstPopulation = true;
    private Thread thread;
    private string name;
    private bool flag = true;
    private List<Fish> fish = new List<Fish>();
    private List<Frog> frog = new List<Frog>();
    private List<Crocodile> crocodile = new List<Crocodile>();
    public string Name { get { return name; } set { name = value; } }
    public bool Flag { get { return flag; } set { flag = value; } }

    public Thread Thread { get { return thread; } set { thread = value; } }

    public Lake(string Name)
    {
        name = Name;
        if (FirstPopulation)
        {
            fish.Add(new Fish("Fish0", name));
            frog.Add(new Frog("Frog0", name));
            crocodile.Add(new Crocodile("Crocodile0", name));
            FirstPopulation = false;
        }

        thread = new Thread(Loop);
        thread.Start();

    }
    private void Loop()
    {
        while (flag)
        {
            randomEvents.WaitRandomTime(1000, 5000);
            MainLogic();
        }
        System.Console.WriteLine("Thred stoped");
    }
    private void MainLogic()
    {
        string specee = specees[randomEvents.PickRandomNum(0, specees.Count())];
        Fish currentFish = fish[randomEvents.PickRandomNum(0, fish.Count())];
        Frog currentFrog = frog[randomEvents.PickRandomNum(0, frog.Count())];
        Crocodile currentCrocodile = crocodile[randomEvents.PickRandomNum(0, crocodile.Count())];
        randomEvents.PickRandomEvent(specee, currentFish, currentFrog, currentCrocodile, ref fish, ref frog, ref crocodile, name);
    }
    public void PrintLake()
    {
        System.Console.WriteLine(
            $"{name} has:\n" +
            $"{fish.Count()} fishes,\n" +
            $"{frog.Count()} frogs,\n" +
            $"{crocodile.Count()} crocodiles"
        );
    }
}
