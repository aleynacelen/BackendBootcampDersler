namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir metin giriniz");
        string metin = Console.ReadLine();
        Console.WriteLine($"{metin.ToLower()}\n {metin.ToUpper()}");
        
        
    }
}
