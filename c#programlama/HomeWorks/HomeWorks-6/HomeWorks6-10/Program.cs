namespace HomeWorks6_10;



public class Karakter
{
    public Karakter(string name, string saglık)
    {
        Name = name;
        Saglık = saglık;
    }

    public string Name { get; set; }
    public string Saglık { get; set; }

    public virtual void BilgiYaz()
    {
        System.Console.WriteLine($"Adı{Name}\n Sağlık{Saglık}");
    }


}
class Savascı : Karakter
{
    public Savascı(string name, string saglık) : base(name, saglık)
    {
    }
    public override void BilgiYaz()
    {
        base.BilgiYaz();
    }
    public void Yetenek()
    {
        System.Console.WriteLine($"{Name}Kılıç salsırısı yapar!");
    }
}
class Büyücü : Karakter
{
    public Büyücü(string name, string saglık) : base(name, saglık)
    {
    }
    public override void BilgiYaz()
    {
        base.BilgiYaz();
    }
    public void Yetenek()
    {
        System.Console.WriteLine($"{Name} Büyüleme yeteneği var");
    }
   
}
class Okcu : Karakter
{
    public Okcu(string name, string saglık) : base(name, saglık)
    {
    }
    public override void BilgiYaz()
    {
        base.BilgiYaz();
    }
    public void Yetenek()
    {
        System.Console.WriteLine($"{Name} Ok fırtlatır!");

    }
}

class Program
{
    static void Main(string[] args)
    {
        // Büyücü büyücü = new Büyücü("Elif","Sağlıklı");
        // büyücü.Yetenek();
        // büyücü.BilgiYaz();
        // Okcu okcu = new Okcu("Mete","sağlıksız");
        // okcu.Yetenek();
        // okcu.BilgiYaz();
        // Savascı savascı = new Savascı("Aleyna","sağlıklı");
        // savascı.BilgiYaz();
        // savascı.Yetenek();


    }
}
