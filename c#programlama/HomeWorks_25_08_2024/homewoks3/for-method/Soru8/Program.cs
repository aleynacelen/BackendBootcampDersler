namespace Soru8;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Pozitif tam sayı giriniz");
        int number = int.Parse(Console.ReadLine());
        for  (int i =number; i>=1 ;i--)
        {
            int square = i * i;
            Console.WriteLine($"{i}^2 ={square}");
        }
    }
}
