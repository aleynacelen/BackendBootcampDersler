using Microsoft.VisualBasic;

namespace HomeWorks6_6;


public class HesapMakikesi
{
    public double Toplam(double a , double b)
    {
        return a+b;

    }
    public double Çıkarma(double a ,double b)
    {
        return a-b;

    }
    public double Carpma(double a , double b)
    {
        return a * b;
    }
    public double Bolme(double a , double b)
    { 
        if(b==0)
        {
            System.Console.WriteLine("bölüm 0 olamaz");

        }
        return a / b;

    }


}

public class BilimselHesapMakinesi:HesapMakikesi
{
    public double Sin (double c )
    {
        return Math.Sin(c);

    }
    public double Cos(double c)
    {
        return Math.Cos(c);

    }
    

}








class Program
{
    static void Main(string[] args)
    {
        // HesapMakikesi hesapMakikesi1 = new HesapMakikesi();
        // System.Console.WriteLine(hesapMakikesi1.Toplam(2,4));
        // System.Console.WriteLine(hesapMakikesi1.Carpma(4,7));
        // System.Console.WriteLine(hesapMakikesi1.Çıkarma(10,7));
        // System.Console.WriteLine(hesapMakikesi1.Bolme(10,0));
        // BilimselHesapMakinesi bilimselHesap = new BilimselHesapMakinesi();
        // System.Console.WriteLine(bilimselHesap.Sin(3));
        // System.Console.WriteLine(bilimselHesap.Cos(6));
    }
}
