namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Bir sayı girin");
    byte number1 = byte.Parse(Console.ReadLine());
    Console.WriteLine("2.sayıyı girin");
    byte number2 = byte.Parse(Console.ReadLine());
   string resultMessage = number1 > number2
   ? $" naber daha büyük" : $"iyicle sayı daha büyük";
   Console.WriteLine(resultMessage);


    }
}
