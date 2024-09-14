namespace Proje03_Variables;

class Program
{
    // static void Main(string[] args)
    // {
    //     #region Değişken İsimlendirme Kural ve Teknikleri
    //     /*
    //         1) C# BÜYÜK/küçük harf duyarlı bir dildir.
    //         Ör: adSoyad ile AdSoyad aynı değildir!

    //         2) Özel karakterler değişken adı içerisinde yer alamaz. Alt tire(_) hariç
    //         Ör: Ad Soyad, Ogrenci-Numarası bunlar geçersiz isimlerdir.
    //         Ör: _AdSoyad, Ad_Soyad
    //         Ör: Sayi1, Sayi_2, Sayi2Var
    //         Ör: 1Sayi, 4Not bunlar geçersiz isimlerdir.Çünkü değişken ismi harf ya da alt tire ile başlamak zorundadır!

    //         3) Anahtar sözcükler yani c#'ın özel anlam yüklediği sözcükler değişken ismi olarak kullanılamaz.
    //         Ör: int static; geçersiz
    //         Ör: string void; geçersiz
    //         Ör: int @static; geçerli

    //         4) Değişkenler anlamlı bir şekilde isimlendirilmelidir.
    //         Ör: string adSoyad;
    //         Ör: bool isActive;
    //         Ör: bool devletOzelTesvikSistemidenYararlaniyorMu;

    //         5) Değişken isimlendirirken camelCase tekniği kullanılmalıdır.
    //         Ör: string anneadi;  strin anne_adi; bunlar camelCase'e uygun değil
    //         Ör: string anneAdi; string mezunOlduğuOkul; uygun örnekler

    //         6) Değişken isimlendirirken Türkçe karakter kullanmak yasak değildir. Ancak tercih etmemeniz şiddetle önerilir!

    //         7) Sabit(Const) tanımlarken genellikle tamamen BÜYÜK HARF kullanılır.
    //         Ör: const int MAX_AGE=40;
    //         Ör: const double PI=3.14;


    //     */
    //     #endregion

    //     #region TamSayılar
    //     // int degiskenAdi=56;
    //     // int degiskenAdi2;
    //     // System.Console.WriteLine(degiskenAdi);

    //     // VS Code: Line Comment Ctrl+ö
    //     // Evrensel: Line Comment Ctrl+K C   Uncomment Ctrl+K U

    //     //Tam Sayılar
    //     //C#'TA AYRICA BELİRTİLMEDİKÇE TÜM SAYISAL DEĞERLER INT TİPİNDE VARSAYILIR!
    //     // byte studentPoint=255;//0 ile 255 1 byte (8 bit)
    //     // System.Console.WriteLine(studentPoint);

    //     // sbyte studentPoint2 = -18; //-128 +127 1 byte
    //     // short price = 500; // 16 bit
    //     // ushort price2 = 65535; //16 bit
    //     // int number = -589; //32 bit
    //     // uint number2 = 97; //32 bit
    //     // long longNumber = 5000000000; //64 bit
    //     // ulong longNumber2 = 545; //64 bit  
    //     #endregion

    //     #region Ondalık Sayılar
    //     // float oran = 0.5F; //32 bit,  hassasiyet: 7 basamak
    //     // double oran2 = 0.5; //64 bit, hassasiyet: 15-16 basamak
    //     // decimal maas = 0.5m; //128 bit, hassasiyet: 28-29 basamak
    //     #endregion

    //     #region Diğer Tipler
    //     bool varMi = true;
    //     bool gecerliMi = false; //8 bit

    //     char cevap = 'H';
    //     char sembol = '&'; //UTF-16 charset, 16 bit
    //     #endregion

    //     #region Value Types(Değer Tipler)
    //     /* Yukarıdaki tüm tiplere c# Value Types der.
    //         Value Types, bellekte içinde direkt olarak değer saklayan yapıları anlatır.
    //         Ayrıca bunlara Primitive Types da denir.
    //     */
    //     #endregion

    //     #region Reference Types(Referans Tipler)
    //     /*
    //     Ram'in Stack kısmında verinin yerine, verinin bulunduğu yerin adresini tutan veri tipleridir. 
    //     Yani bir reference type, bir neseneyi ya da değeri işaret eder.
    //     */
    //     #endregion

    //     #region Temel Referans Tipler
    //     string adSoyad = "Engin Niyazi Ergül";
    //     object nesne = 15;
    //     object nesne2 = true;
    //     object nesne3 = "Merhaba";
    //     //String ve Object tiplerinin bellekte ne kadar yer kapladığını araştırınız.
    //     #endregion

     string number = "125&";
     int numberInt = int.Parse(number);
    Console.WriteLine(numberInt);




}
}

