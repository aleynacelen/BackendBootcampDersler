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

        System.Console.WriteLine("Bir harf giriniz");
        char harf = Convert.ToChar(Console.ReadLine());
         harf = char.ToLower(harf);
        switch(harf){
            case 'a':
            case 'b':
            case 'C':
        
            System.Console.WriteLine('sesli harf');
            break;
            default:
            System.Console.WriteLine("sesiz harf");
            break;
        }















    }
}
