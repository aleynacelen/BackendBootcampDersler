namespace HomeWorks6_4;
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public int Isbn { get; set; }
   

    public Book(string title, string author, int pages, int ısbn)
    {
        Title = title;
        Author = author;
        Pages = pages;
        Isbn = ısbn;
    }

    public Book()
    {
    }

    public virtual void Barrow()
    {
        System.Console.WriteLine($"{Title} ödünç alındı");

    }
    public virtual void Retrun()
    {
        System.Console.WriteLine($"{Title} İade edildi");

    }
}

class Library : Book
{
    public Library(string title, string author, int pages, int ısbn) : base(title, author, pages, ısbn)
    {
    }


}








class Program
{
    static void Main(string[] args)
    {
        // Book book1 = new Book ("Edebiyat Romanı","Halit Ziya Uşaklı gil",200,1234);
        // book1.Barrow();
        // book1.Retrun();
    }
}
