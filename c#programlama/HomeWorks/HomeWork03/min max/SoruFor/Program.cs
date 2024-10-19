namespace SoruFor;

class Program
{
    static void Main(string[] args)
    {
       int min = int.MaxValue;
       int max = int.MinValue;
       for(int i =0; i<5; i++)
       {
        Console.Write("bir sayı giriniz");
        int number = int.Parse(Console.ReadLine());
        if (number<min)
        {
            min =number;

        }
        if(number>max)
        {
            max=number;

        }

       }
       Console.WriteLine($"En küçük değer:{min}");
       Console.WriteLine($"en büyük değer: {max}");
    }
}
