namespace Soru9;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Pozitif bir sayı giriniz");
        int number = int.Parse(Console.ReadLine());

        if(number<=1)
        {
            Console.WriteLine("Asal sayı değildir");
            return;
        }
        bool isPrime =true;
        for(int i = 2; i<= Math.Sqrt(number); i++)
        {
            if (number % == 0)
            {
                isPrime= false;
                break;
            }
        }
        if(isPrime)
        {
            Console.WriteLine("asal sayı d");

        }
        else
        {
            Console.WriteLine("Asal syı değildir");

        }
    }
}
