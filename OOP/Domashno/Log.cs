namespace Domashno;

public static class Log
{
    public static Queue<string> log = new Queue<string>();
    public static bool DoQuit = false;

    public static void FlushLog()
    {
        Console.CancelKeyPress += new ConsoleCancelEventHandler(Console_CancelKeyPress);

        while (true)
        {
            if (!(log.Count() == 0))
            {
                for (int i = 0; log.Count() > i; i++)
                {
                    System.Console.WriteLine(log.Dequeue());
                }
            }
            else if (DoQuit)
            {
                break;
            }
        }
    }
    public static void Add(string text)
    {
        log.Enqueue(text);
        if (log.Count() > 100)
        {
            log.Dequeue();
        }
    }
    private static void Console_CancelKeyPress(object? sender, ConsoleCancelEventArgs e)
    {
        e.Cancel = true;
        Console.WriteLine("Ctrl + c was pressed");
        DoQuit = true;
    }

}
