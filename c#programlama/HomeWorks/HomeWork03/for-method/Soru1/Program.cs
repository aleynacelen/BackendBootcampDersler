namespace Soru1;

class Program
{
    static void Main(string[] args)
    {
      


        Console.Write("Pozitif bir tam sayı girin: ");
        
      
        if (int.TryParse(Console.ReadLine(), out int sayi))
        {
           
            if (sayi <= 0)
            {
                Console.WriteLine("Lütfen pozitif bir tam sayı girin.");
            }
            else
            {
                int toplam = 0;

                for (int i = 1; i <= sayi; i++)
                {
                    toplam += i;
                }

                Console.WriteLine($"1'den {sayi}'ye kadar olan sayıların toplamı: {toplam}");
            }
        }
        else
        {
            Console.WriteLine("Geçerli bir tam sayı girin.");
        }
    }
}


    


    

