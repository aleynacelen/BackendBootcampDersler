namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen bir cümle giriniz:");
        string cumle = Console.ReadLine();
        string[] kelimeler = cumle.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int kelimeSayisi = kelimeler.Length;
        Console.WriteLine($"Cümledeki kelime sayısı: {kelimeSayisi}");
    
    }
}
