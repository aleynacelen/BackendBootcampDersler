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

    //Ödev13 Belirli bir metin içinde geçen kelimeleri sayan bir metot yazın.
    static int kelimeBul(string kelime)
        {
            foreach (var item in collection)
            {
                
            }

        }






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




    }





}
