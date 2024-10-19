namespace Soru8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("BİR SAYI GİRİN");
        double number = double.Parse(Console.ReadLine());
        double number2 = Math.Log(number);
        Console.WriteLine(number2);
    }
}
