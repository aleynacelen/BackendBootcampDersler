namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("bir sayı giriniz (1-5 arasında)");
        string input = Console.ReadLine();
        int value;
        bool deger = int.TryParse(input,out value);
        if(deger)
        {
            switch(value)
            {
                case 1:
                Console.WriteLine("1 kuruş");
                break;
                case 2:
                Console.WriteLine("5 kuruş");
                break;
                case 3:
                Console.WriteLine("10 KURUŞ");
                break;
                case 4:
                Console.WriteLine("15 Kuruş");
                break;
                case 5:
                Console.WriteLine("50 KURUŞ");
                break;
                default:
                Console.WriteLine("geçersiz");
                break;



            }
            Console.WriteLine($"GİRDİĞİNİZ SAYININ KURUŞ DEĞERİ {value}");
           


        }


    

    }
}
