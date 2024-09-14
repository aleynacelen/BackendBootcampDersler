namespace Soru10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("sayı giriniz");
        double input = double.Parse(Console.ReadLine());
        if (input % input==0 && input % 1 ==0)
        {
            Console.WriteLine("ASAL SAYI");
        }
        else
        {
            Console.WriteLine("ASAL DEĞİL");
        }
    }
}
