namespace SoruWhile;

class Program
{
    static void Main(string[] args)
    {
        int min = int.MinValue;
        int max= int.MaxValue;
        while(count<5)
        {
            Console.Write("Bir sayı girin.");
            int number = int.Parse(Console.ReadLine());

            // Min ve Max değerlerini güncelle
            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }

            count++;
        }

        // Sonuçları ekrana yazdır
        Console.WriteLine($"En küçük değer: {min}");
        Console.WriteLine($"En büyük değer: {max}");


    }
    }
}
