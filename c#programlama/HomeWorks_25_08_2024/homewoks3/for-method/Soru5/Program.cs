namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("1-100 arasında bir pozitif sayı giriniz");
       for(int number=2 ; number <=100;number++)
       bool isPrime ture;

       for(int i =2 ;i<=Math.Sqrt(number); i++)
       if(number % i== 0)
       {
        isPrime=false;
        break;

       }
    }
    if(isPrime)
    {
        Console.WriteLine(number);

    }
}
