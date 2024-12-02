using System.Data;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace MethodsOdev;

class Program
{

    //ÖDEV 1
    // static string YasKontrol( int yas1 )

    // {

    //       string message;
    //         if(yas1>=65)
    //         {
    //             message= $"emeklikik yasında";
    //             System.Console.WriteLine(message);


    //         }
    //         else
    //         {
    //             message = $"çalışma yaşında";
    //             System.Console.WriteLine(message);
    //         }

    //             return message;
    // }

    //ÖDEV2
    // static string BüyükKüçükSayı(int sayı1, int sayı2)
    // {

    //     string message;
    //     if (sayı1 > sayı2)
    //     {
    //         message = $"1. girilen sayı daha büyük";
    //         Console.WriteLine(message);


    //     }
    //     else
    //     {
    //         message = $"2. girilen sayı daha büyük";
    //         Console.WriteLine(message);

    //     }
    //     return message;

    // }

    //Ödev 3
    // static string TersCevir(string kelime)
    // {
    //     char[] karakterler = kelime.ToCharArray();

    //     Array.Reverse(karakterler);

    //     string tersKelime = new string(karakterler);

    //     return tersKelime;
    //     static void Main(string[] args)
    //     {
    //         Console.Write("Bir kelime giriniz: ");
    //         string girisKelime = Console.ReadLine();

    //         string tersKelime = TersCevir(girisKelime);

    //         Console.WriteLine("Ters çevrilmiş kelime: " + tersKelime);
    //     }





    // }

    //Ödev4
    // static int Notlar (int vizeNotu, int finaslNotu)
    // // {

    //     int a= vizeNotu*40/100;

    //     int b =finaslNotu*60/100;
    // int c =a+b;


    //   return c;


    // }
    //Ödev5

    // static string TersÇev(string[] dizi)
    // {
    //     foreach (var item in dizi)
    //     {
    //         System.Console.WriteLine(item.ToUpper());
    //     }
    //     return dizi;

    // // } 
    //Ödev 6
    // {
    //     string message ;
    //     if(sayi%2==0)
    //     {
    //         message=$"Bu sayı çifttir ve Girdiğiniz sayı:{sayi}";
    //         System.Console.WriteLine(message);

    //     }
    //     else
    //     {
    //         message=$"Girdiğiniz sayı tektir ve girdiğiniz sayı{sayi}";
    //         System.Console.WriteLine(message);

    //     }
    //     return message;

    // }
    //ödev7

    // static void Main()

    // {

    //     int saat = a;
    //     int dakika=b ;
    //     int saniye= c;
    //     DateTime zaman =FormatTime(a,b,c);
    //     System.Console.WriteLine("");



    // }
    //Ödev8

    // static double DereceCevir(double fahrenheit )
    // {
    //     double celcıus=fahrenheit-32
    //     System.Console.WriteLine(celcıus);

    // }

    //Ödev9
    // static int [] dizi()
    // {
    //     int[] sayılar={2,3,4,5,6,7,8,9,10,11};
    //     Array.Sort(sayılar);
    //     System.Console.WriteLine(sayılar[0]);
    //     return sayılar;

    // }
    //ödev10
    // int sayılar={4,5,2,1,2,4,5,6,7,8,};
    // int toplam =0;
    // for(int i =0; i<sayılar.Lenght;i++)
    // {
    //     toplaö+=sayılar[i];
    //     System.Console.WriteLine(toplam);
    // }
    // int[] sonuc new int(toplam)
    // return sonuç;

    // //ödev11
    // static int sesBul(string kel){}
    // string sesli="aeıioöuüAEIİOÜ";
    // int sayaç=0;
    // foreach (var item in kel)
    // {
    //     sayaç++
    // }
    // System.Console.WriteLine(sayaç);
    // return sayaç;
    //ödev12 

    // public static string gunBul(DateTime tarih){
    //     DayOfWeek gun = tarih.DayOfWeek;
    //     return gun.ToString();
    // }
    // static void Main()
    // System.Console.WriteLine("Bir tarih giriniz(yyyy-MM-dd formatında)");
    // DateTime girilenTarih = DateTime.Parse(Console.ReadLine());

    //Ödev13 Belirli bir metin içinde geçen kelimeleri sayan bir metot yazın.
    // public static int KelimeBul(string metin, string aranankelime)
    // metin = metin.ToLower();
    // aranankelime= aranankelime.ToLower();
    // string[] kelimeler =metin.Split(' ', ',', '.', '!', '?', ';', ':');
    // int sayac = 0;
    // foreach (string kelime in kelimeler)
    // {
    //     if (kelime==aranankelime){
    //         sayac++;
    //     }
    // }
    // return sayac;


    //Ödev14 İki tarih arasındaki gün sayısını hesaplayan bir metot yazın.

    // public static int gunSayisiHesapla(DateTime tarih1 DateTime tarih2){
    //     TimeSpan fark tarih2-tarih1
    //     return Math.Abs(fark.Days);
    // } ödev 15 Bir dizideki elemanların ortalamasını döndüren bir metot yazın.


    // static void Main(strinf[] args){

    //         int[] dizi = { 2, 3, 4, 5, 6, 7, 8, 9 };
    //         double ortalama =Ortalama(dizi);
    //         System.Console.WriteLine("dizideki elemanların ortalaması :"+ortalama);


    //     }

    //   public static double Ortalama(int[] dizi){
    //     foreach(int sayı in dizi){
    //         toplam+=sayı;
    //         double ortalama =(double)toplam/dizi.Lenght;
    //         return ortalama
    //     }
    //   }
    //Ödev16
    // public class PalindromKontrol
    // {
    //     public static bool IsPalindrome(string kelime)
    //     {

    //         kelime = kelime.ToLower();


    //         kelime = kelime.Replace(" ", "");


    //         string tersKelime = new string(kelime.Reverse().ToArray());

    //         return kelime == tersKelime;
    //     }

    // public int SayiyiBul (List<int> liste, int aranansayi)

    // int sayac=0;
    // foreach (int sayi in liste)


    // {
    //   if(sayi==aranansayi) {
    //     sayac++;
    //   }
    //   return sayac;
    // }
    //ödev18

    // public string TamIsim (string ad,string soyad)
    // {
    //     return ad+" "+soyad;
    // }

    //ödev19
    //sor

    //ödev20

    // public static string StringleriBirleştir(string[] dizi)
    // {
        
    //     return string.Join(" ", dizi);
    // }


















    static void Main(string[] args)
    {
        // YasKontrol(65);
        // BüyükKüçükSayı(2,3);
        //Console.WriteLine("Ters çevrilmiş kelime: " + tersKelime);

        // System.Console.WriteLine(Notlar(40,50));

        // string[] mehmet = {"ahmet","aleyna","elif","burak"};
        // TersÇev(mehmet);
        // // TekCift( 5972);
        // Console.WriteLine("derece giriniz");
        // int input=int.Parse(Console.ReadLine());
        // System.Console.WriteLine(DereceCevir(input));
        // dizi();
        // System.Console.WriteLine("bir kelime giriniz");
        //     string input=Console.ReadLine();
        //     kelime(input);  
        //  string gun =GunBul(tarih);
        //  System.Console.WriteLine("girdiğiniz tarih:"+gun);


        // Console.WriteLine("Bir metin giriniz: ");
        // string metin = Console.ReadLine();

        // Console.WriteLine("Aramak istediğiniz kelimeyi giriniz: ");
        // string aranankelime = Console.ReadLine();

        // int kelimeSayisi = KelimeBul(metin, aranankelime);
        // Console.WriteLine("Girdiğiniz metinde '" + aranankelime + "' kelimesi " + kelimeSayisi + " kez geçiyor.");
        // Console.WriteLine("Birinci tarihi giriniz (yyyy-MM-dd formatında): ");
        // DateTime tarih1 = DateTime.Parse(Console.ReadLine());

        // Console.WriteLine("İkinci tarihi giriniz (yyyy-MM-dd formatında): ");
        // DateTime tarih2 = DateTime.Parse(Console.ReadLine());
        // int gunSayisi = GunSayisiHesapla(tarih1, tarih2);
        // Console.WriteLine("İki tarih arasındaki gün sayısı: " + gunSayisi);
        // string kelime = "kayak"; 

        // if (IsPalindrome(kelime))
        // {
        //     Console.WriteLine("{0} bir palindromdur.", kelime);
        // }
        // else
        // {
        //     Console.WriteLine("{0} bir palindrom değildir.", kelime);
        // }



        // List<int> sayilar = new List<int> { 1, 2, 3, 4, 5, 3, 6, 3, 7, 3 };
        // int aranansayi = 3;
        // int tekrarSayisi = SayiyiBul(sayilar, arananSayi);
        // Console.WriteLine($"{arananSayi} sayısı listede {tekrarSayisi} defa geçiyor.");

        // Console.Write("Adınızı girin: ");
        // string ad = Console.ReadLine();
        // Console.Write("Soyadınızı girin: ");
        // string soyad = Console.ReadLine();
        // string tamIsim = TamIsim(ad, soyad);
        // Console.WriteLine("Tam isminiz: " + tamIsim);
        // string[] kelimeler = { "selam", "canım", "nasılsın" };
        // string birlesmisString = StringleriBirleştir(kelimeler);
        // Console.WriteLine("Birleşmiş string: " + birlesmisString);




    }





}
