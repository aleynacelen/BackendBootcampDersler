namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("bir ondalıklı sayı giriniz");
        double number = double.Parse(Console.ReadLine());

        double newNumber= Math.Round(number);
        Console.WriteLine(newNumber);
    }
}
