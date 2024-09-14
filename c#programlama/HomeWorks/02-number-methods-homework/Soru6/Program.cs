namespace Soru6;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Değer gir");
       double sin1 = double.Parse(Console.ReadLine());
       double sinresult = Math.Sin(sin1);
       Console.WriteLine(sinresult);
    }
}
