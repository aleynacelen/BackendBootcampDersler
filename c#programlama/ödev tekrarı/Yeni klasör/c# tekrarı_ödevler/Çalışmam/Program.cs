using System.ComponentModel;
using System.Data.Common;
using System.Net;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text.Json.Serialization.Metadata;

namespace Çalışmam;

class Program
{
    static void Main(string[] args)
    {
        //    int number1=5;
        //    int number2=7;
        //    int toplam;
        //    toplam= number1+number2;
        //    Console.WriteLine(toplam);

        // double a =87.5;
        // double karesi;
        // karesi = a*a;
        // System.Console.WriteLine("sayının karesi"+ karesi);


        // string isim= "Aleyna";
        // int yas =24;
        // System.Console.WriteLine($"Benim Adım{isim}ve ben {yas} yasındayım");

        // Console.Write("Bir metin giriniz");
        // string metin = Console.ReadLine();

        // string buyuk = metin.ToUpper();
        // string kucuk = metin.ToLower();

        // Console.WriteLine($"{buyuk}\n{kucuk}");

        //  System.Console.WriteLine("Bir cümle giriniz");

        //  string cümle = Console.ReadLine();

        //  string değişencumle = cümle.Trim(' ');

        //  System.Console.WriteLine($"değişen cümle {değişencumle}");


        // string cumle = Console.ReadLine();
        // string kelime =Console.ReadLine();
        // int index = cumle.IndexOf(kelime);
        // System.Console.WriteLine(index);     


        // double sayi = Convert.ToDouble(Console.ReadLine());
        // int yuvarlanan = (int)Math.Round(sayi);
        // System.Console.WriteLine(sayi);

        //    System.Console.WriteLine("bir sayı giriniz");
        //     double sayı = Convert.ToDouble(Console.ReadLine());


        // int yas = 24;
        // string name="Aleyna";

        // System.Console.WriteLine($"Benim adım {name}, yaşım {yas}");

        // double sayi= 12.3;
        // double hesaplanansayi = sayi*sayi;
        // System.Console.WriteLine(hesaplanansayi);


        // string sonuc ="true";
        // bool sonuc1 = Convert.ToBoolean(sonuc);
        // Console.WriteLine(sonuc1);

        // double pi = 3.14159234832089429429;
        // float pi2 = (float)pi;
        // System.Console.WriteLine(pi2);

        // string isim ="Mete Aleyna";
        // int karakterayısı = Convert.ToInt16(isim.Length);
        // System.Console.WriteLine(karakterayısı);

        //------1.ödevtekrarıBitti-------
        // System.Console.WriteLine("Bir cümle giriniz");
        // string cümle = Console.ReadLine();
        // int karaktersayısı =cümle.Length;
        // System.Console.WriteLine(karaktersayısı);

        // System.Console.WriteLine("bircümle girin");
        // string girilencumle = Console.ReadLine();

        // string[] kelimeler = girilencumle.Split(' ');
        // int toplamKarakter =0;
        //  for (int i = 0; i < girilencumle.Length; i++)
        //  {
        //     toplamKarakter+=kelimeler[i].Length;


        //  }
        //  System.Console.WriteLine(toplamKarakter);

        //     System.Console.WriteLine("Lütfen Bir cümle giriniz");
        //     string cumle = Console.ReadLine();

        //     string büyük = cumle.ToLower();
        //     string kücük = cumle.ToUpper();
        // Console.Write($"{büyük}\n{kücük}");

        // System.Console.WriteLine("bir cümle girin");

        //  string girilencumle= Console.ReadLine();

        //  System.Console.WriteLine("aranıcak kelimeyi giriniz");
        //  string kelime =Console.ReadLine();

        //  string[] kelimeler =girilencumle.Split(' ');
        //  int sayac=0;
        //  for (int i = 0; i < kelimeler.Length; i++)
        //  {
        //     if(kelimeler[i]==kelime)
        //     {
        //         sayac++;

        //     }

        //  }
        //  System.Console.WriteLine(sayac);

        // Console.WriteLine("Bir metin girin:");
        // string metin = Console.ReadLine();

        // Console.WriteLine("Aramak istediğiniz metni girin:");
        // string arananMetin = Console.ReadLine();
        // int indeks= metin.IndexOf(arananMetin);
        // if (indeks!=-1){
        //     System.Console.WriteLine(indeks);
        // }
        // else{
        //     System.Console.WriteLine("aranan metin bulunamadı");
        // }

        //     System.Console.WriteLine("bir sayı giriniz");

        //    double sayi = Convert.ToDouble(Console.ReadLine());

        //    int yuvarlanan=(int)Math.Round(sayi);
        //    System.Console.WriteLine(yuvarlanan);

        // int sayi1 = Convert.ToInt32(Console.ReadLine());
        // int sayi2 = Convert.ToInt32(Console.ReadLine());
        // if(sayi1>sayi2){
        //     System.Console.WriteLine("1.sayı daha büyük");
        // }else if(sayi2>sayi1){
        //     System.Console.WriteLine("ikinci sayı daha büyük");
        // }
        // else{
        //     System.Console.WriteLine("iki sayı eşittir");
        // }

        //  double sayi = Convert.ToDouble(Console.ReadLine());
        //  double yenisayi = Math.Sqrt(sayi);
        //  System.Console.WriteLine(yenisayi);

        // double sayi1 = Convert.ToDouble(Console.ReadLine());
        // double sayi2 = Convert.ToDouble(Console.ReadLine());
        // if(sayi1<sayi2){
        //     System.Console.WriteLine("sayi1 daha küçük");
        // }else if(sayi2<sayi1){
        //     System.Console.WriteLine("sayi2 daha küçük");
        // }
        // else
        // {
        //     System.Console.WriteLine();
        // }

        // double sayi = Convert.ToDouble(Console.ReadLine());

        // int basamak = Convert.ToInt32(Console.ReadLine());

        // double yuvarlanan =Math.Round(sayi,basamak);
        // System.Console.WriteLine(yuvarlanan);
        // System.Console.WriteLine("bir karakter gir");
        // char harf = Convert.ToChar(Console.ReadLine());
        // bool sesliHarfmi = harf=='a'|| harf =='e'|| harf=='o'|| harf == 'ö';
        // if(sesliHarfmi){
        //     System.Console.WriteLine("girilen karakter sesli");
        // }else
        // {
        //     System.Console.WriteLine("değil");
        // }

        // System.Console.WriteLine("bir yıl giriniz");
        // int yil = Convert.ToInt32(Console.ReadLine());
        // bool artıkYilmi =(yil%4==0&& yil%100!=0)|| yil%400==0;
        // if(artıkYilmi){
        //     System.Console.WriteLine("artık yıl");
        // }else{
        //     System.Console.WriteLine("değil");
        // }

        // System.Console.WriteLine("Öğrencinin notunu giriniz");
        // int not = int.Parse(Console.ReadLine());

        // if(90<=not&& not<=100)
        // {
        // System.Console.WriteLine("Harf notu : A");
        // }else if(not>=80) {
        //     System.Console.WriteLine("HARF NOTU B");

        // }
        // else{
        //    System.Console.WriteLine("HARF NOTU C");
        // }

        // System.Console.WriteLine("Bir sayı giriniz:");
        // double sayi = Convert.ToDouble(Console.ReadLine());
        //         System.Console.WriteLine("Bir sayı giriniz:");
        //         double sayi1 = Convert.ToDouble(Console.ReadLine());
        //         System.Console.WriteLine("Bir işaret giriniz");
        // char isaret = char.Parse(Console.ReadLine());
        // if(isaret=='*'){
        //     double sonuc= sayi*sayi1;
        //     System.Console.WriteLine(sonuc);

        // }else if(isaret=='-'){
        //     double sonuc= sayi-sayi1;
        //     System.Console.WriteLine(sonuc);

        // }
        // else if(isaret=='+'){
        //     double sonuc = sayi+sayi1;
        //     System.Console.WriteLine(sonuc);
        // }
        // else{
        //     if(sayi==0){
        //         System.Console.WriteLine("geçerli bir sayı giriniz");

        //     }
        //     else{
        //         double sonuc=sayi/sayi1;
        //         System.Console.WriteLine(sonuc);

        //     }
        // }

        // System.Console.WriteLine("bir sayı gir1-7");
        // int sayı = int.Parse(Console.ReadLine());
        // switch (sayı)
        // {
        //     case 1:
        //         System.Console.WriteLine("pazartesi");
        //         break;
        //     case 2:
        //         System.Console.WriteLine("salı");
        //         break;
        //     case 3:
        //         System.Console.WriteLine("çarşamba");
        //         break;


        //     default:
        //         System.Console.WriteLine("1-3 arasında sayı giriniz");
        //         break;
        // }

        // System.Console.WriteLine("Bir harf giriniz");
        // char harf = Convert.ToChar(Console.ReadLine());
        //  harf = char.ToLower(harf);
        // switch(harf){
        //     case 'a':
        //     case 'b':
        //     case 'C':

        //     System.Console.WriteLine('sesli harf');
        //     break;
        //     default:
        //     System.Console.WriteLine("sesiz harf");
        //     break;
        // }

        // DateTime şimdikizaman = DateTime.Now;

        //  System.Console.WriteLine(şimdikizaman.ToString("dd.MM.yyy"));

        // System.Console.WriteLine("bir tarih giriniz");
        // DateTime time = Convert.ToDateTime(Console.ReadLine());
        // DateTime nowtime = DateTime.Now;
        // TimeSpan fark= nowtime-time;
        // System.Console.WriteLine($"günfarkı:{fark.Days} gün");
        // System.Console.WriteLine("tarih giriniz");
        // string input = (Console.ReadLine());
        // DateTime time;

        // if(DateTime.TryParse(input,out time)){
        //     DateTime nowtime = DateTime.Now;
        //     TimeSpan fark =nowtime-time;
        //     System.Console.WriteLine($"fark:{fark.Days} gün");

        // }else{
        //     System.Console.WriteLine("geçersiz tarih ");
        // }

        //    System.Console.WriteLine("Lütfen yyyy-MM-dd formatında bir tarih giriniz");
        //    System.Console.WriteLine("lütfen HH:mm:ss formatında saat giriniz");
        //    DateTime simdikiZaman = DateTime.Parse(Console.ReadLine());
        //    TimeSpan simdikiSaat=TimeSpan.Parse(Console.ReadLine());
        //    DateTime tamTarih = simdikiZaman.Add(simdikiSaat);
        //    System.Console.WriteLine(tamTarih.ToString("yyyy-MM-dd HH:mm:ss"));


        //     System.Console.WriteLine("bir tarih giriniz");
        //    DateTime zaman =DateTime.Parse(Console.ReadLine());
        //    string gun = zaman.DayOfWeek.ToString();
        //    System.Console.WriteLine($"Bugün günlerden {gun}");

        //  System.Console.WriteLine("Bir tarih giriniz (yyyy-MM-dd HH:mm:ss)formatında");
        //  DateTime time = DateTime.Parse(Console.ReadLine());
        //  TimeSpan saat = TimeSpan.Parse(Console.ReadLine());
        //  DateTime tamzaman = time.Add(saat);

        //  System.Console.WriteLine($"bir hafta sonraki tarih : {tamzaman.AddDays(7)}");

        // System.Console.WriteLine("Bir tarih gir (yyyy-MM-dd HH:mm:ss)formatında olsun");
        // DateTime time = DateTime.Parse(Console.ReadLine());
        // DateTime birHaftasonra = time.AddDays(7);
        // System.Console.WriteLine($"Bir hafta sonraki tarih :{birHaftasonra.ToString("yyyy-MM-dd HH:mm:ss")}");

        //         System.Console.WriteLine("doğum gününü gir ");
        //         DateTime dogumGunu = DateTime.Parse(Console.ReadLine());
        //         DateTime 
        // simdikizaman = DateTime.Now;
        //         TimeSpan fark = dogumGunu-simdikizaman;
        //         System.Console.WriteLine($"aradaki fark {fark.ToString("yyyy-MM-dd")}"); 
        // int toplam =0;
        // for (int i = 1; i < 100; i++)
        // {
        //     if(i%2==0){
        //         System.Console.WriteLine(i);
        //         toplam+=i;
        //     }

        // }
        // System.Console.WriteLine($"1'den 100e kadar olan çift sayı toplamı {toplam}");


        // for (int i = 1; i <= 50; i++)
        // { if(i%2!=0)
        //             {
        //                 System.Console.WriteLine(i);

        //             }


        // }

        // int toplam = 0;
        // for (int i = 1; i <= 100; i++)
        // {
        //     if(i%3==0){
        //         System.Console.WriteLine(i);
        //         toplam+=i;
        //         System.Console.WriteLine(toplam);
        //     }
        // }

        // System.Console.WriteLine("Lütfen bir pozitif sayı giriniz");
        // int sayi = int.Parse(Console.ReadLine());



        //     if(sayi<0){
        //         for (int i = 0; i < length; i++)
        //         {
        //                 int sayiküpü = i * i * i;
        //                 System.Console.WriteLine(sayiküpü);

        //             }

        //     }
        //     else
        //     {
        //         Console.WriteLine("Lüten pozitif bir sayı giriniz");
        //     }



        // System.Console.WriteLine("Lütfen pozitif bir tamsayı giriniz");

        // int girilenSayi = int.Parse(Console.ReadLine());

        // if(girilenSayi>0)
        // {
        //     for (int i = 1; i <= girilenSayi; i++)
        //     {
        //        for (int j = 1; j < i; j++)
        //        {
        //         System.Console.Write("*");

        //        }
        //        System.Console.WriteLine();


        //     }

        // }
        // else{
        //     System.Console.WriteLine("Negatif bir sayı girdiniz");
        // }


        // System.Console.WriteLine("Lütfen bir sayı giriniz");
        // int girilenSayi = int.Parse(Console.ReadLine());
        // int toplam =0;
        // do
        // {
        //     toplam += girilenSayi;
        //     girilenSayi--;

        //     System.Console.WriteLine($"Toplam: {toplam}");
        // } while (girilenSayi >=0);

        // System.Console.WriteLine("Lütfen pozitif sayı giriniz");
        // int sayi=  int.Parse(Console.ReadLine());
        // int toplam = 0;


        // do
        // {

        //     toplam+=sayi;
        //     System.Console.WriteLine($"Toplam:{toplam}");

        //     System.Console.WriteLine("Lütfen yeni bir sayı giriniz");
        //     sayi=int.Parse(Console.ReadLine());

        // } while (sayi>=0);

        // System.Console.WriteLine($"negatif bir sayı gidiniz: toplam {toplam}");

        // Random rnd = new Random();
        // int hedefSayi = rnd.Next(0, 101);
        // int tahmin;
        // int denemeSayisi = 0;


        // do
        // {
        //     System.Console.WriteLine("Lütfen(0-100)arasında bir sayı giriniz");
        //     tahmin = int.Parse(Console.ReadLine());
        //     denemeSayisi++;
        //     if (tahmin > hedefSayi)
        //     {
        //         System.Console.WriteLine("daha küçük bir sayı dene");
        //     }
        //     else if (tahmin < hedefSayi)
        //     {
        //         System.Console.WriteLine("daha büyük bir sayı dene");
        //     }

        // } while (tahmin != hedefSayi);
        // System.Console.WriteLine("tebrikler, {denemeSayisi} kadar denemede bildiniz");

        // System.Console.WriteLine("Lütfen pozitif bir sayı giriniz");
        // int sayi = int.Parse(Console.ReadLine());
        // int faktoriyel =1;
        // int sayac = sayi;

        // if( sayi<0){
        //     System.Console.WriteLine("Negatif bir sayı girdiniz");
        // }
        // else
        // {
        //     do
        //     {
        //         faktoriyel*=sayac;
        //         sayac--;

        //     } while (sayac>0);
        //     System.Console.WriteLine($"{sayi}! : {faktoriyel}");



        // }

        // System.Console.WriteLine("Pozitif bir sayı giriniz");
        // int sayi;
        // int toplam = 0;
        // sayi = int.Parse(Console.ReadLine());
        // if (sayi < 0)
        // {
        //     System.Console.WriteLine("negatif bir sayı girdiniz tekrar deneyin");
        //     sayi = int.Parse(Console.ReadLine());

        // }
        // else
        // {
        //     while (sayi > 0)
        //     {
        //         toplam += sayi;

        //         sayi--;
        //     }
        //     System.Console.WriteLine($"toplam sayı :{toplam}");

        // }

        // int[] sayilar = new int[5];

        // for (int i = 0; i < sayilar.Length; i++)
        // {
        //     System.Console.WriteLine($"Lütfen {i+1}. sayıyı giriniz");
        //     sayilar[i]=int.Parse(Console.ReadLine());
        // }
        // System.Console.WriteLine("girdiğiğiniz sayılar");
        // for (int i = 0; i < sayilar.Length; i++)
        // {
        //    System.Console.WriteLine(sayilar[i]); 
        // }

        // int[] sayilar = new int[5];
        // for (int i = 0; i < sayilar.Length; i++)
        // {
           
            
        //         System.Console.WriteLine($"lütfen {i+1} .adet pozitif sayı giriniz");
        //         sayilar[i] = int.Parse(Console.ReadLine());

        // }
        // int enbuyukSayi = int.MaxValue;
        //     int enkucukSayi = int.MinValue;


        // for (int i = 0; i < sayilar.Length; i++)
        // {
        //    if(sayilar[i]>enbuyukSayi){
        //     enbuyukSayi =sayilar[i];

        //    }
        //    else{
        //     enkucukSayi=sayilar[i];

        //    }
        // }
        // System.Console.WriteLine($"en büyük sayi{enbuyukSayi}\n en küçük sayi {enkucukSayi}");
        // System.Console.WriteLine("öğrencilerin notları");
        // int toplam =0;

        // int[] notlar ={70,85,90,60,75};

        // int enYuksek =notlar[0];
        // int enDusuk = notlar[0];
        // for (int i = 0; i < notlar.Length; i++)
        // {

        //     System.Console.WriteLine(notlar[i]);
        //     toplam+= notlar[i];
        //     if(notlar[i]>enYuksek)
            
        //         enYuksek=notlar[i];

        //     if(notlar[i]<enDusuk)
        //         enDusuk=notlar[i];

            
        // }
           
        //     double ortalama =(double)toplam/notlar.Length;
        // System.Console.WriteLine($"Notların ortalaması = {ortalama}");

        //     System.Console.WriteLine($"en düşük not = {enDusuk}");
        //     System.Console.WriteLine($"en yüksek not ={enYuksek}");
// System.Console.WriteLine("Lütfen 5 adet sayı giriniz");
// int[] girilenSayi =  new int[5];
// int toplam = 0;
// int enbuyukSayi;
// int endusukSayi;
// for (int i = 0; i < girilenSayi.Length; i++)
// {
//     System.Console.WriteLine($"Sayı {i+1}:");
//     girilenSayi[i]= Convert.ToInt32(Console.ReadLine());
//     toplam+=girilenSayi[i];

// }

// enbuyukSayi=girilenSayi[0];
// endusukSayi=girilenSayi[0];
// for (int i = 1; i < girilenSayi.Length; i++)
// {
//             if (girilenSayi[i] > enbuyukSayi)
//             {
//         enbuyukSayi=girilenSayi[i];

//     }
//             if (girilenSayi[i] < endusukSayi)
//             {
//         endusukSayi=girilenSayi[i];

//     }
// }

// double ortalama=(double)toplam/girilenSayi.Length;

// System.Console.WriteLine($"Sayıların toplamı {toplam}");
// System.Console.WriteLine($"Sayıların ortalaması{ortalama}");
// System.Console.WriteLine($"enbuyukSayi{enbuyukSayi}");
// System.Console.WriteLine( $"en kucuk sayi {endusukSayi}");


























        }
    }
