using System.Runtime.InteropServices;

namespace Zoo;

public static class ZooStatistics
{
    public static int animalCount;
    private static int operationCount;
    private static string lastReport = "";
    private static double totalFoodPerDay;
    private static double avaregeAnimalWeight;

    public static double AvaregeAnimalWeight(Repository<Animal> animals)
    {
        double weight = 0;
        foreach (var animal in animals.objects)
        {
            weight += animal.Weight;
        }
        avaregeAnimalWeight = Math.Round(weight / animals.Count(), 2);
        operationCount++;
        return avaregeAnimalWeight;
    }
    public static double TotalDailyFood(Repository<Animal> animals)
    {
        double food = 0;
        foreach (var animal in animals.objects)
        {
            food += animal.DailyFoodKg();
        }
        totalFoodPerDay = Math.Round(food, 2);
        operationCount++;
        return totalFoodPerDay;
    }
    public static Animal HeaviestAnimal(Repository<Animal> animals)
    {
        Animal heaviestAnimal = new Animal();
        double weight = -1;
        foreach (var animal in animals.objects)
        {
            if (animal.Weight > weight)
            {
                heaviestAnimal = animal;
            }
        }
        operationCount++;
        return heaviestAnimal;
    }
    public static void FindByDiet(Repository<Animal> animals, string diet)
    {
        operationCount++;
        foreach (var animal in animals.objects)
        {
            if (animal.Diet == diet)
            {
                System.Console.WriteLine(animal.ToString());
            }
        }
    }
    public static void AssignedZookeeper(Repository<Animal> animals, Repository<Zookeeper> zookeepers, string zone)
    {
        operationCount++;
        bool foundZookeeper = false;
        foreach (var zookeeper in zookeepers.objects)
        {
            if (zookeeper.Zone.ToLower() == zone.ToLower())
            {
                if (!foundZookeeper)
                {
                    System.Console.WriteLine("Zookeepers:");
                }
                foundZookeeper = true;
                System.Console.WriteLine(zookeeper.ToString());
            }
        }
        if (foundZookeeper)
        {
            bool foundAnimal = false;
            foreach (var animal in animals.objects)
            {
                if (animal.Zone.ToLower() == zone.ToLower())
                {
                    if (!foundAnimal)
                    {
                        System.Console.WriteLine("Animals:");
                    }
                    foundAnimal = true;
                    System.Console.WriteLine(animal.ToString());
                }
            }
            if(!foundAnimal)
            {
                System.Console.WriteLine("No animals found for thsi zone");
            }
        }
        else
        {
            System.Console.WriteLine("No zookeepers found for this zone");
        }
    }
    public static void Report()
    {
        operationCount++;
        
        System.Console.WriteLine(
            $"===Zoo Report===\n" + 
            $"Total animals: {animalCount}\n" +
            $"  Avarage weight: {avaregeAnimalWeight}kg\n"+
            $"  Total food/day: {totalFoodPerDay}kg\n"+
            $"  Last report: {lastReport}"
        );
        lastReport = DateTime.Now.ToString("h:mm:ss tt");
        
    }
}
