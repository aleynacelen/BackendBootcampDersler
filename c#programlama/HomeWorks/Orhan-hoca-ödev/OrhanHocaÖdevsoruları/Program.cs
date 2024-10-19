namespace OrhanHocaÖdevsoruları;

class Program
{
    static void Main(string[] args)
    {

        #region Hesap Makinesi Hazırlama



        // System.Console.WriteLine("Kaç adet sayı girmek istersiniz");
        // int kacadet = int.Parse(Console.ReadLine());
        // double toplam=0;
        // for (int i = 0; i < kacadet; i++)
        // {
        //     Console.Write("{0}. sayı girin", i+1);
        //     toplam += double.Parse(Console.ReadLine());

        // }
        // double ortalama = toplam/kacadet;
        // System.Console.WriteLine($"Toplam değer :{toplam}");
        // System.Console.WriteLine($"Ortama değer :{ortalama}");

        // System.Console.WriteLine("Hangi işlemi yapmak istersiniz");
        // char islem = Convert.ToChar(Console.ReadLine());
        // System.Console.WriteLine("Kaç adet sayı ile işlem yapmak istersiniz");
        // int adet =  int.Parse(Console.ReadLine());
        // List<double> sayilar = new List<double>();
        // for (int i = 0; i < adet; i++)
        // {
        //     System.Console.WriteLine("{0}. sayıyı giriniz", i+1);
        //     sayilar.Add(Convert.ToDouble(Console.ReadLine()));

        // }
        // double sonuc= sayilar[0];
        // for (int i = 0; i < adet; i++)
        // {

        //        switch (islem)
        //     {
        //         case '+':
        //             sonuc += sayilar[i];
        //             break;
        //         case '-':
        //             sonuc -= sayilar[i];
        //             break;
        //         case '*':
        //             sonuc *= sayilar[i];
        //             break;
        //         case '/':
        //             sonuc /= sayilar[i];
        //             break;

        //         default:
        //             Console.WriteLine("Geçersiz işlem!");
        //             return;
        //     }

        //     System.Console.WriteLine($"Sonuç = {sonuc}");



        // }













        #endregion

        #region Alışveris
        // string[] urunler ={"Tavuk","Süt","Elma","Dondurma","Yumurta","Zetin","Sıvıyağ","Helva"};
        // double[] price ={3,4,10,20,2.1,7,10.7,12};
        // double fiyatToplamı = 0;
        // System.Console.WriteLine("ürünler:");
        // for (int i = 0; i < urunler.Length; i++)
        // {
        //     System.Console.WriteLine("{0} : {1} tl ",urunler[i],price[i]);
        // }
        // System.Console.WriteLine("Ne almak istiyorsunuz");
        // while (true)
        // {
        //     string urun = Console.ReadLine();
        //     if(urun.ToLower()=="t")
        //     {
        //         break;

        //     }
        //     for (int i = 0; i < urunler.Length; i++)
        //     {
        //         if (urun.ToLower() == urunler[i].ToLower())
        //         {
        //             fiyatToplamı += price[i];
        //             break;
        //         }


        //     }
        //     System.Console.WriteLine("Tolam tutar:"+ fiyatToplamı+"tl");

        //     while (true)
        //     {
        //         string ürun = Console.ReadLine();
        //        if(ürun.ToLower()=="t") 
        //        {
        //         break;

        //        }
        //        Console.Write("Kaç adet {0} almak istiyorsun",urun);
        //        int adet = Convert.ToInt32(Console.ReadLine());
        //        for (int i = 0; i < urunler.Length; i++)
        //        {
        //         if(urun.ToLower()==urunler[i].ToLower())
        //         {
        //             fiyatToplamı +=price[i]*adet;
        //             break;

        //         }
        //        }
        //     }
        //     System.Console.WriteLine("ürünler ve tutarları");
        //     System.Console.WriteLine("Fiyat toplamı:"+fiyatToplamı+"tl");

        // }








        #endregion
        #region Oyun

        string[] options = { "taş", "kağıt", "makas" };
        int oyuncuSkoru = 0, bilgisayarSkoru = 0;

        while (true)
        {
            Console.WriteLine("Taş, kağıt veya makas seçiniz (Çıkış için 'çıkış'):");
            string oyuncuSecimi = Console.ReadLine().ToLower();

            if (oyuncuSecimi == "çıkış")
            {
                break;
            }
            Random random = new Random();
            int bilgisayarIndex = random.Next(0, 3);
            string bilgisayarSecim = options[bilgisayarIndex];

            Console.WriteLine("Bilgisayarın seçimi: " + bilgisayarSecim);
            if (oyuncuSecimi == bilgisayarSecim)
            {
                Console.WriteLine("Berabere!");
            }
            else if ((oyuncuSecimi == "taş" && bilgisayarSecim == "makas") ||
                     (oyuncuSecimi == "kağıt" && bilgisayarSecim == "taş") ||
                     (oyuncuSecimi == "makas" && bilgisayarSecim == "kağıt"))
            {
                oyuncuSkoru++;
                Console.WriteLine("Tebrikler, kazandınız!");
            }
            else
            {
                bilgisayarSkoru++;
                Console.WriteLine("Üzgünüz, kaybettiniz!");
            }

            Console.WriteLine("Skor: Oyuncu - {0}, Bilgisayar - {1}", oyuncuSkoru, bilgisayarSkoru);

            #endregion
            #region quiz
            string[] sorular = { "Gökyüzü ne renktir?", "Türkiye'nin başkenti neresidir?" };
            string[] cevaplar = { "mavi", "Ankara" };
            string[] seceneklerString = { "kırmızı|Mavi|Pembe|Mor", "Ankara|İstanbul|İzmir" };

            int dogruSayisi = 0;
            int yanlisSayisi = 0;

            for (int i = 0; i < sorular.Length; i++)
            {
                Console.WriteLine(sorular[i]);

                
                string[] secenekler = seceneklerString[i].Split('|');
                for (int j = 0; j < secenekler.Length; j++)
                {
                    Console.WriteLine((j + 1) + ". " + secenekler[j]);
                }

                Console.Write("Cevabınız: ");
                string kullaniciCevap = Console.ReadLine().ToLower(); 

                if (kullaniciCevap == cevaplar[i])
                {
                    Console.WriteLine("dogru cevap");
                    dogruSayisi++;
                }
                else
                {
                    Console.WriteLine("cevap yanlış");
                    yanlisSayisi++;
                }
            }

            Console.WriteLine("\nDoğru sayısı: " + dogruSayisi);
            Console.WriteLine("Yanlış sayısı: " + yanlisSayisi);

            #endregion








        }
}
