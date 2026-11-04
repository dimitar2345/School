using System.Runtime.InteropServices;

namespace Zoo;

public class Repository<T>
{
    public List<T> objects = new List<T>();

    public void Add(T element)
    {
        if (element != null && element.GetType() == typeof(Animal))
        {
            ZooStatistics.animalCount++;
        }
        objects.Add(element);
    }
    public void RemoveAt(int index)
    {
        if (objects[index] != null && objects[index].GetType() == typeof(Animal))
        {
            ZooStatistics.animalCount--;
        }
        objects.RemoveAt(index);
    }
    public void PrintAll()
    {
        foreach (T obj in objects)
        {
            if (obj != null)
            {
                System.Console.WriteLine(obj.ToString());
            }
        }
    }
    public int Count()
    {
        return objects.Count();
    }
}
