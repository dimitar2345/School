using System.Collections.Specialized;

namespace Zoo;

public class Animal
{
    private string id;
    private string name;
    private string species;
    private int age;
    private double weight;
    private string zone;
    private string diet;
    private double dailyFoodKg;
    public double Weight {get { return weight; } }
    public string Diet {get { return diet; } }
    public string Zone {get { return zone; } }
    public Animal(){}
    public Animal(string id,string name,string species,int age,double weight,string zone,string diet,double dailyFoodKg)
    {
        this.id = id;
        this.name = name;
        this.species = species;
        this.age = age;
        this.weight = weight;
        this.zone = zone;
        this.diet = diet;
        this.dailyFoodKg = dailyFoodKg;
    }
    public override string ToString()
    {
        return ($"{id} | {name} | {species} | {age} | {weight} | {zone} | {diet} | {dailyFoodKg}");
    }
    public bool IsAdult()
    {
        if(age > 10)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public double DailyFoodKg()
    {
        return dailyFoodKg;
    }
}
