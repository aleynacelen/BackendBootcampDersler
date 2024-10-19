namespace Soru10;
using System;

class Program
{
    static void Main()
    {
        Console.Write("Başlangıç sayısını girin: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Bitiş sayısını girin: ");
        int end = int.Parse(Console.ReadLine());

        long product = 1; 

       
        for (int i = start; i <= end; i++)
        {
            product *= i;
        }

        
        Console.WriteLine($"Sonuç: {product}");
    }
}
