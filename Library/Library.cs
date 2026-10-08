namespace Library;

class Library<T>
{
    private static List<Book<int>> books = new List<Book<int>>();
    private static Random random = new Random();
    public Library()
    {
        while (true)
        {
            Console.WriteLine("Enter options add, remove,display or exit");
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "add":
                    AddBook();
                    break;
                case "remove":
                    Remove();
                    break;
                case "display":
                    Display(); break;
                case "exit":
                    Environment.Exit(0);
                    break;
                case "display all":
                    DisplayAll();
                    break;
                default:
                    Console.WriteLine("Try again");
                    break;
            }
        }

    }
    public void AddBook()
    {
        int Id = random.Next(1000, 3000);
        Console.WriteLine("Enter the title:");
        string Title = Console.ReadLine();
        Console.WriteLine("Enter the Author:");
        string Author = Console.ReadLine();
        Console.WriteLine("Enter the year:");
        string Year = Console.ReadLine();
        Console.WriteLine("Enter the genre");
        string Genre = Console.ReadLine();

        books.Add(new Book<int>(Id, Title, Author, Year, Genre));
    }
    public void Remove()
    {
        Console.WriteLine("Enter the cryteria:");
        string cryteria = Console.ReadLine();
        Console.WriteLine("Enter the value:");
        string value = Console.ReadLine();
        foreach (Book<int> book in books)
        {
            books.Remove(Find(cryteria, value));
        }

    }
    public void Display()
    {
        Console.WriteLine("Enter the cryteria:");
        string cryteria = Console.ReadLine();
        Console.WriteLine("Enter the cryteria:");
        string value = Console.ReadLine();
        foreach (Book<int> book in books)
        {
            Find(cryteria, value).Display();
        }
    }
    public void DisplayAll()
    {
        foreach (Book<int> book in books)
        {
            book.Display();
            Console.WriteLine();
        }
    }
    private Book<int> Find(string cryteria, string value)
    {
        foreach (Book<int> book in books)
        {
            {
                switch (cryteria.ToLower())
                {
                    case "id":
                        if (book.Id.ToString() == value)
                        {
                            return book;
                        }
                        break;
                    case "title":
                        if (book.Title.ToString() == value)
                        {
                            return book;
                        }
                        break;
                    case "author":
                        if (book.Author.ToString() == value)
                        {
                            return book;
                        }
                        break;
                    case "year":
                        if (book.Year.ToString() == value)
                        {
                            return book;
                        }
                        break;
                    case "genre":
                        if (book.Genre.ToString() == value)
                        {
                            return book;
                        }
                        break;
                }
            }
        }
        return null;
    }
}
