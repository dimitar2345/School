using Microsoft.VisualBasic;
using System;
using System.Text;

namespace Domashno;

public class RandomEvents
{
    public static Random random = new Random();

    public int PickRandomNum(int a, int b)
    {
        return random.Next(a, b);
    }

    public void WaitRandomTime(int a, int b)
    {
        System.Threading.Thread.Sleep(random.Next(a, b));
    }

    public void PickRandomEvent(string specees, Fish fish, Frog frog, Crocodile crocodile, ref List<Fish> FishList, ref List<Frog> FrogList, ref List<Crocodile> CrocodileList, string habitat)
    {
        int num = random.Next(1, 4);

        if (specees == "fish")
        {
            switch (num)
            {
                case 1:
                    if (FrogList.Count() > 1)
                    {
                        fish.Eat(frog);
                        FrogList.Remove(frog);
                    }
                    break;
                case 2:
                    fish.Move();
                    break;
                case 3:
                    fish.Reproduce(ref FishList, habitat);
                    break;
            }
        }
        else if (specees == "frog")
        {
            switch (num)
            {
                case 1:
                    if (CrocodileList.Count() > 1)
                    {
                        frog.Eat(crocodile);
                        CrocodileList.Remove(crocodile);
                    }
                    break;
                case 2:
                    frog.Jump();
                    break;
                case 3:
                    frog.NewFrog(ref FrogList, habitat);
                    break;
            }
        }
        else if (specees == "crocodile")
        {
            switch (num)
            {
                case 1:
                    if (FishList.Count() > 1)
                    {
                        crocodile.Hunt(fish);
                        FishList.Remove(fish);
                    }
                    break;
                case 2:
                    crocodile.Rest();
                    break;
                case 3:
                    crocodile.NewCrocodile(ref CrocodileList, habitat);
                    break;
            }
        }
    }

}
