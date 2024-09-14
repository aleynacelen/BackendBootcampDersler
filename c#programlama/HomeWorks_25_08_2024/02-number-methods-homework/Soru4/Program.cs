namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Değer giriniz");
       double numara = double.Parse(Console.ReadLine());
       double numara2 = Math.Sqrt(numara);
       Console.WriteLine(numara2);
    }
}
