//Koleksiyon Yapıları:C#da dizi benzeri bir veri yapısını ifade eder ve birkaç türü vardır
//1)IEnumarable:En temel collection yapılarından birdir ve şu özelliklere sahiptir:
//*Iterastion sağlar (döngü kurabilme)
//*verilerin sadece okunması gereken durumlarda tercih edilir(READONLY)*Bu durumda ekleme silme gibi operasyonlara izin vermez
//*ÖZELLİKLE FOREACH DÖNGÜSÜ İLE KULLANMAYA OLDUKÇA UYGUNDUR!!!
//Verileri belleğe almadan işlem yapar(direkt belleğin üzerinde işlem yapar)

// using System.Diagnostics.Tracing;

// List<string> names = new List<string>{"Ali","Veli","Murat","Sezen"};
// IEnumerable<string> enumarableNames=names;
// foreach (var name in enumarableNames)
// {
//     System.Console.WriteLine(name);
// }
//ICollection: IEnumarableden türetilmiştir.
//ek olarak şu özelliklere sahiptir:
//veri ekleme ve silme operasyonlarını destekler
//eleman sayısını öğrenme imkanı sağlar
//Veri üzerinde iteration yaparken menipülasyon yapma ihtiyacı olan durumlarda tercih edilir.
// ICollection<string> names = new List<string> { "Ali", "Veli", "Murat", "Sezen" };
// System.Console.WriteLine(names.Count);
//IList: ICollectiondan türetilmiştir. Ek olarak sahip olduğu özellliikler şunlardır:
//Indexleme imkanı sunar.
//bu sayede collection elemanlarına bir index numarası ile erişebilir([])
//Sıralı veri yapılarında tercih ederiz
// IList<string> names = new List<string> { "Ali", "Veli", "Murat", "Sezen" };
// System.Console.WriteLine(names[0]);

//IQuerable: Bu collection yapısı daha özel amaçlara hizmet eder:
//Daha çok veritabanı sorguları oluşturmak için tercih edilir
//Sorguyu , veri tabanına göndermeden önce optimize 
//Büyük veri setlerinde çok ciddi bir performans sağlar
//filtreleme oprerasyonlarını direkt olarak veri tabı üzerinde yaparak hız kazandırır 
//


