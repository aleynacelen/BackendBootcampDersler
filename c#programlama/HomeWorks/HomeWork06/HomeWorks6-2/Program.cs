using System.Collections.Concurrent;

namespace HomeWorks6_2;

public class Veichle
{
    public Veichle(string marka, string model, int yıl)
    {
        Marka = marka;
        Model = model;
        Yıl = yıl;
    }

    public string Marka { get; set; }
    public string Model { get; set; }
    public int Yıl { get; set; }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Marka: {Marka}\nModel: {Model}\nModel Yılı: {Yıl}");
    }


}
class Car : Veichle
{
    public Car(string marka, string model, int yıl, int numberOfDoors) : base(marka, model, yıl)
    {
        NumberOfDoors = numberOfDoors;
    }
    public int NumberOfDoors { get; set; }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        System.Console.WriteLine($"Kapı sayısı {NumberOfDoors}");
    }


}
class Bicyle : Veichle
{
    public Bicyle(string marka, string model, int yıl, int numberOfWheels) : base(marka, model, yıl)
    {
        NumberOfWheels = numberOfWheels;
    }
    public int NumberOfWheels { get; set; }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        System.Console.WriteLine($"Teker sayısı{NumberOfWheels}");
    }

}

class Motorcycle : Veichle
{
    public Motorcycle(string marka, string model, int yıl, bool hasidecar) : base(marka, model, yıl)
    {
        Hasidecar = hasidecar;
    }
    public bool Hasidecar { get; set; }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        System.Console.WriteLine($"yan sepet var mı {Hasidecar}");
    }
}



class Program
{
    static void Main(string[] args)
    {
        Motorcycle motorcycle1 =new Motorcycle("Hond","mt100",2003,true);
        motorcycle1.DisplayInfo();
        
        Bicyle bicyle1 = new Bicyle("bianca","a100",2019,3);
        bicyle1.DisplayInfo();
        Car car1 = new Car("Bmw","d500",2024,2);
        car1.DisplayInfo();
    }
}
