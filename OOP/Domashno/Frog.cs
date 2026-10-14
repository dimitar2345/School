namespace Domashno;

public class Frog
{
    List<string> colors = new List<string>()
    {
      "red",
      "green",
      "yellow",
      "blue",
      "pink",
      "brown",
      "cyan",
    };
    private string color;
    private string habitat;
    private string name;
    public string Name { get { return name; } set { name = value; } }

    public Frog(string Name, string Habitat)
    {
        habitat = Habitat;
        name = Name;
        color = colors[RandomEvents.random.Next(0, colors.Count() - 1)];
    }

    public void Jump()
    {
        Log.Add($"{name} is jumping in {habitat}!");
    }
    public void Eat(Crocodile crocodile)
    {
        Log.Add($"{name} is eating {crocodile.Name} in {habitat}!");
        Log.Add($"{crocodile.Name} was eaten in {habitat}!");
    }
    public void NewFrog(ref List<Frog> frog, string habitat)
    {
        if (frog.Count() == 0)
        {
            frog.Add(new Frog("Frog0", habitat));
        }
        if (frog.Count() == 0)
        {
            frog.Add(new Frog("Frog0", habitat));
        }
        frog.Add(new Frog($"Frog{frog.Count()}", habitat));
        Log.Add($"Frog{frog.Count()} was born in {habitat}!");
    }

}
