namespace Soru3;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Tarihi (yyyy-MM-dd) formatında girin: ");
        string tarihInput = Console.ReadLine();

        
        Console.Write("Eklemek istediğiniz gün sayısını girin: ");
        int gunSayisi;
        bool gunSayisiGeçerli = int.TryParse(Console.ReadLine(), out gunSayisi);

        if (!gunSayisiGeçerli)
        {
            Console.WriteLine("Geçersiz gün sayısı.");
            return;
        }

        
        DateTime tarih;
        if (DateTime.TryParse(tarihInput, out tarih))
        {
            DateTime yeniTarih = tarih.AddDays(gunSayisi);
            Console.WriteLine($"Yeni tarih: {yeniTarih.ToString("yyyy-MM-dd")}");
        }
        else
        {
            Console.WriteLine("Geçersiz tarih formatı.");
        }

    }
}
