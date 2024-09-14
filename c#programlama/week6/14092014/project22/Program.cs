namespace project22;

class Bird
{
    public void Fly()
    {
        System.Console.WriteLine("kuş uçuyor!");

    }
}

class Penguen :Bird//(base class)(miras alınan sınıf)
{
    public void Swim()
    {
        Penguen penguen1 = new Penguen();
        penguen1.Swim();
        penguen1.Fly();


    }
}

class Otomobil
{
    public string Marka { get; set; }   
    public string  Model { get; set; }  
    public string Renk { get; set; }    
    public int ModelYili { get; private set; }  


}
class IctenYanmalıOtomobil:Otomobil
{
    public string YakıtTipi { get; set; }   
    public string MotorGucu { get; set; }

}

class ElektirikliOto:Otomobil
{
    public string Menzil { get; set; }  
    public bool KendiniSarjetme { get; set; }
}













class Program
{
    static void Main(string[] args)
    {
        ElektirikliOtomobil elektirikliOtomobil1=new ElektirikliOtomobil();
        elektirikliOtomobil1.Marka();
    }
}
