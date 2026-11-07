namespace OnlineShop;

public static class Security
{
    public static string IdGenerate()
    {
        Random rand = new Random();
        string result = "";
        char letter;
        for(int i = 0; i < 10;i++)
        {
            int temp = rand.Next(0,255);

            letter = Convert.ToChar(temp);
            result += letter;
        }
        return result;
    }
}
