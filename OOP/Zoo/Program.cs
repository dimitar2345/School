using System;

namespace Zoo;

internal class Program
{
    public static void Main(String[] args)
    {
        Repository<Zookeeper> zookeepers = new Repository<Zookeeper>();
        Repository<Animal> animals = new Repository<Animal>();


        zookeepers.Add(new Zookeeper("auisdgi12123", "jon", 12, "steps"));
        zookeepers.Add(new Zookeeper("buefgh23456", "sara", 8, "savanna"));
        zookeepers.Add(new Zookeeper("cvfghj34567", "mike", 15, "river"));
        zookeepers.Add(new Zookeeper("dwghik45678", "anna", 20, "mountain"));
        zookeepers.Add(new Zookeeper("exhijl56789", "tom", 5, "desert"));
        zookeepers.Add(new Zookeeper("fyijkm67890", "lisa", 10, "savanna"));
        zookeepers.Add(new Zookeeper("gzjklm78901", "david", 25, "forest"));
        zookeepers.Add(new Zookeeper("halkmn89012", "emma", 3, "river"));
        zookeepers.Add(new Zookeeper("iblmno90123", "james", 18, "mountain"));
        zookeepers.Add(new Zookeeper("jcmnop01234", "olivia", 7, "savanna"));

        animals.Add(new Animal("a1", "Lion1", "Lion", 5, 150.5, "savanna", "Carnivore", 5.0));
        animals.Add(new Animal("a2", "Elephant1", "Elephant", 10, 4000.0, "savanna", "Herbivore", 20.0));
        animals.Add(new Animal("a3", "Tiger1", "Tiger", 3, 180.0, "jungle", "Carnivore", 3.5));
        animals.Add(new Animal("a4", "Giraffe1", "Giraffe", 8, 1200.0, "savanna", "Herbivore", 15.0));
        animals.Add(new Animal("a5", "Zebra1", "Zebra", 6, 400.0, "plains", "Herbivore", 8.0));
        animals.Add(new Animal("a6", "Cheetah1", "Cheetah", 2, 60.0, "savanna", "Carnivore", 2.0));
        animals.Add(new Animal("a7", "Hippo1", "Hippo", 15, 3000.0, "river", "Herbivore", 18.0));
        animals.Add(new Animal("a8", "Rhino1", "Rhino", 12, 2500.0, "grassland", "Herbivore", 12.0));
        animals.Add(new Animal("a9", "Leopard1", "Leopard", 4, 70.0, "forest", "Carnivore", 2.5));
        animals.Add(new Animal("a10", "Buffalo1", "Buffalo", 9, 800.0, "grassland", "Herbivore", 10.0));

        zookeepers.PrintAll();
        System.Console.WriteLine();
        System.Console.WriteLine();
        animals.PrintAll();
        System.Console.WriteLine();
        System.Console.WriteLine();
        System.Console.WriteLine(ZooStatistics.HeaviestAnimal(animals).ToString());
        System.Console.WriteLine();
        System.Console.WriteLine();
        System.Console.WriteLine(ZooStatistics.AvaregeAnimalWeight(animals).ToString());
        System.Console.WriteLine();
        System.Console.WriteLine();
        System.Console.WriteLine(ZooStatistics.TotalDailyFood(animals).ToString());
        System.Console.WriteLine();
        System.Console.WriteLine();
        ZooStatistics.AssignedZookeeper(animals,zookeepers,"savanna");
        System.Console.WriteLine();
        System.Console.WriteLine();
        ZooStatistics.FindByDiet(animals,"Carnivore");
        ZooStatistics.Report();

    }
}