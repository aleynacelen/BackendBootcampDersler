namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        while (true)
        {
            Console.Write("Pozitif bir tam sayı girin (veya çıkmak için 0 girin):");
            int number = int.Parse(Console.ReadLine());
            if(number == 0)
            { 
                break;

            }

            sum += number;

        }
        Console.WriteLine($"Girilen sayıların toplamı: {sum}");
    }
}
