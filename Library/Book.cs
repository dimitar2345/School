namespace Library;

class Book<T>
{
    private T id;
    private string title;
    private string author;
    private string year;
    private string genre;
    public T Id { get { return id; } }
    public string Title { get { return title; } }
    public string Author { get { return author; } }
    public string Year { get { return year; } }
    public string Genre { get { return genre; } }

    public Book(T id, string title, string author, string year, string genre)
    {
        this.id = id;
        this.title = title;
        this.author = author;
        this.year = year;
        this.genre = genre;
    }
    public void Display()
    {
        Console.WriteLine($"The book {title} with id {id}\n" +
            $"writen by the author {author} in {year}" +
            $"in the gener {genre}.");
    }
}
