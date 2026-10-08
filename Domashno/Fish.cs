namespace Domashno;

public class Fish
{
    private string name;
    private static int population;
    private bool isMeatEater;

    private string habitat;

    public string Name { get { return name; } set { name = value; } }
    public static int Population { get { return population; } set { population = value; } }

    public Fish(string Name, string Habitat)
    {
        habitat = Habitat;
        name = Name;
        int index = RandomEvents.random.Next(0, 2);

        if (index == 0)
            isMeatEater = false;
        else
            isMeatEater = true;

    }
    public void Eat(Frog frog)
    {
        Log.Add($"{name} is eating {frog.Name} in {habitat}!");
        Log.Add($"{frog.Name} was eaten in {habitat}!");
    }

    public void Move()
    {
        Log.Add($"{name} is moving in {habitat}!");
    }
    public void Reproduction()
    {
        Log.Add($"{name} was born in {habitat} {(isMeatEater ? "and it eats meat" : "and it does not eat meat")}!");
        population += 1;
    }
    public void Reproduce(ref List<Fish> fish, string habitat)
    {
        int newBornFishes = RandomEvents.random.Next(1, 30);
        if (fish.Count() == 0)
        {
            fish.Add(new Fish("Fish0", habitat));
            fish[0].Reproduction();
        }
        for (int i = fish.Count(); i < newBornFishes; i++)
        {
            fish.Add(new Fish($"Fish{i}", habitat));
            fish[i].Reproduction();
        }

    }
}
