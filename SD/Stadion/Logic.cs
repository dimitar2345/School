namespace Stadion;

public class Logic
{
    List<Stadion> stadions = new List<Stadion>();
    public Logic()
    {
        while (true)
        {


            QualityControl.PrintMenu();
            switch (QualityControl.Input(4))
            {
                case 1:
                    stadions.Add(new Stadion(QualityControl.Input(0)));
                    break;
                case 2:
                    foreach (Stadion st in stadions)
                    {
                        st.Print();
                    }
                    break;
                case 3:
                    if(stadions == null || stadions.Count() == 0)
                    {
                        break;
                    }
                    for (int i = 0; i < stadions.Count(); i++)
                    {
                        System.Console.Write(i+1 + ".");
                        stadions[i].Print();

                    }
                    stadions.RemoveAt(QualityControl.Input(4)-1);
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
