namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Değer girin");
        double alt = double.Parse(Console.ReadLine());
        Console.WriteLine("2.değeri giriniz");
        double üst = double.Parse(Console.ReadLine());
        double result = Math.Pow(alt,üst);
        Console.WriteLine(result);
        
    }
}
