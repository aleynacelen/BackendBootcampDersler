namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir pozitif sayı giriniz");
        int number = int.Parse(Console.ReadLine());
        if(number<0)
        {
            Console.WriteLine("pozitif bir tam sayı giriniz");
            return;

        }
        int reversNumber=0;

        while(number>0)
        {

            int remainder =number%10
            reversedNumber=(reversedNumber*10)+ remainder;
            number=number/10;

        }
        Console.WriteLine("Tersine çevirilmiş sayı:"+reversedNumber);
    }
}
