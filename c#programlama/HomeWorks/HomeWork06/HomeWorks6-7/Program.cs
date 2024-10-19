namespace HomeWorks6_7;

public class Product
{
    public Product(string name, int price, int stockQuantity)
    {
        Name = name;
        Price = price;
        StockQuantity = stockQuantity;
    }

    public string Name { get; set; }
    public int Price { get; set; }
    public int StockQuantity { get; set; }

    public virtual void BilgiYaz()
    { 
        System.Console.WriteLine($"ADI:{Name}\nFİYAT:{Price}\nStok{StockQuantity}");

    }


}

public class GıdaProduct : Product
{
    public GıdaProduct(string name, int price, int stockQuantity, bool glutenVarmi) : base(name, price, stockQuantity)
    {
        GlutenVarmi = glutenVarmi;
    }
    public bool GlutenVarmi  { get; set; }
    public override void BilgiYaz()
    {
        base.BilgiYaz();
        System.Console.WriteLine($"Gluten var mı ? {GlutenVarmi}");
    }
}


public class ElektirikProduct : Product
{
    public ElektirikProduct(string name, int price, int stockQuantity, bool sarjEtme) : base(name, price, stockQuantity)
    {
        SarjEtme = sarjEtme;
    }
    public bool SarjEtme { get; set; }
    public override void BilgiYaz()
    {
        base.BilgiYaz();
        System.Console.WriteLine($"Sarj etme özelliği{SarjEtme} ");
    }
}












class Program
{
    static void Main(string[] args)
    {
        // GıdaProduct gıdaProduct = new GıdaProduct("Yulaf ezmesi",5,50,true);
        // ElektirikProduct elektirikProduct = new ElektirikProduct("Telefon", 1001, 4, false);
    }
}
