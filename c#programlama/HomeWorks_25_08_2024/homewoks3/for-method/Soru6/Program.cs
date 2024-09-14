namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
       
        int number;
        Console.Write("10'dan büyük bir pozitif tam sayı girin: ");
        number = int.Parse(Console.ReadLine());

        if (number <= 10)
        {
            Console.WriteLine("Girilen sayı 10'dan büyük olmalıdır.");
            return; 
        }

       
        for (int i = 1; i <= number; i++)
        {
            int square = i * i;
            Console.WriteLine($"{i}^2 = {square}");
        }
    }
}
