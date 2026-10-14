namespace Domashno;

public class Crocodile
{
    private string name;
    private string habitat;
    public string Name { get { return name; } set { name = value; } }
    public Crocodile(string Name, string Habitat)
    {
        habitat = Habitat;
        name = Name;
    }
    public void Hunt(Fish fish)
    {
        Log.Add($"{name} is hunting {fish.Name} in {habitat}!");
        Log.Add($"{fish.Name} was eaten in {habitat}!");
        Fish.Population -= 1;
    }
    public void Rest()
    {
        Log.Add($"{name} is resting in {habitat}!");
    }
    public void NewCrocodile(ref List<Crocodile> crocodile, string habitat)
    {
        if (crocodile.Count() == 0)
        {
            crocodile.Add(new Crocodile("Crocodile0", habitat));
        }
        if (crocodile.Count() == 0)
        {
            crocodile.Add(new Crocodile("Crocodile0", habitat));
        }
        crocodile.Add(new Crocodile($"Crocodile{crocodile.Count()}", habitat));
        Log.Add($"Crocodile{crocodile.Count() - 1} was born in {habitat}!");
    }
}
