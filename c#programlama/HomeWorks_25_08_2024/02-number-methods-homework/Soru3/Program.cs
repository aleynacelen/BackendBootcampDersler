namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir değer giriniz");

        sbyte number = sbyte.Parse(Console.ReadLine());
        sbyte number2 = Math.Abs(number);
        Console.WriteLine(number2);
        
        
    
    }
}
