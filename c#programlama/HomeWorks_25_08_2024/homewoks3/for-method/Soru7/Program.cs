namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("pozitif bir ssayı giriniz");

        int number = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i =2; i <=number; i+=2)
        {
            sum += i;

        }
        Console.WriteLine($"1den {number}'a kadar olan çift sayıların toplamı : {sum}");
    }



}
