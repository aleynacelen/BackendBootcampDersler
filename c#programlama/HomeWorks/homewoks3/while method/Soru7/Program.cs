namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir pozitif tam sayı girin: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("bir üst sınır değeri girin :");
        int upperLimit = int.Parse(Console.ReadLine());

        if (number<= || upperLimit <= 0)
        {
            Console.WriteLine("Lütfen bir pozitif tam sayılar girin");
            return;


        }

        if(number>= upperLimit)
        { Console.WriteLine("ilk sayının üst sınırdan küçük olması gerekiyor");
        return;

        }

        while(number< upperLimit)
        {
            Console.WriteLine("Mevcut sayı:" +number);

        }
    }
}
