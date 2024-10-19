namespace HomeWorks6_5;

public class Event
{
    public Event(string name, DateTime date, string location)
    {
        Name = name;
        Date = date;
        Location = location;
    }

    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public virtual void EtkinlikBasladı()
    {
        System.Console.WriteLine($"{Name} etkinliği başladı");

    }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"iSİM: {Name}\nTarih: {Date}\n Yer: {Location}");
    }


}
class Birthday : Event
{
    public Birthday(string name, DateTime date, string location) : base(name, date, location)
    {
    }
    public override void EtkinlikBasladı()
    {
        System.Console.WriteLine($"{Name} basladı");

    }
}
class Meeting : Event
{
    public Meeting(string name, DateTime date, string location) : base(name, date, location)
    {

    }
    public override void EtkinlikBasladı()
    {
        System.Console.WriteLine($"{Name} basladı");

    }
}
class Task : Event
{
    public Task(string name, DateTime date, string location) : base(name, date, location)
    {
    }
    public override void EtkinlikBasladı()
    {
        System.Console.WriteLine($"{Name} basladı");

    }
}

class Program
{
    static void Main(string[] args)
    {
        //  Birthday birthday1 = new Birthday("Aleyanın doğum günü",DateTime.Now,"Sarıyer");
        //  birthday1.EtkinlikBasladı();
        //  birthday1.DisplayInfo();
        //  Task task1 = new Task("FlomarEvent", DateTime.Now,"Ümraniye");
        //  task1.EtkinlikBasladı();
        //  task1.DisplayInfo();
        //  Meeting meeting1 = new Meeting("Online toplantı",DateTime.Now,"Konumunuz");
        //  meeting1.EtkinlikBasladı();
        //  meeting1.DisplayInfo();

    }
}
