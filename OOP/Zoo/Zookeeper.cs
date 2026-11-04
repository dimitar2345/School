namespace Zoo;

public class Zookeeper
{
    private string id;
    private string name;
    private int experience;
    private string zone;
    public string Zone {get { return zone; } }
    public Zookeeper(string id,string name, int experience, string zone)
    {
        this.id = id;
        this.name = name;
        this.experience = experience;
        this.zone = zone;
    }
    public override string ToString()
    {
        return $"{id} | {name} | {experience} | {zone}";
    }

}
