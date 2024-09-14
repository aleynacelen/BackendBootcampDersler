namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("birinci metin giriniz");
        string metin1 =Console.ReadLine();
        Console.WriteLine("ikinci metni giriniz");
        string metin2 =Console.ReadLine();
        int indeks = metin1.IndexOf(metin2);

           if (indeks != -1)
        {
            Console.WriteLine($"'{metin2}' kelimesi '{metin1}' metninde ilk olarak {indeks} indeksinde bulunuyor.");
        }
        else
        {
            Console.WriteLine($"'{metin2}' kelimesi '{metin1}' metninde bulunamadı.");
        }
        

    }
}
