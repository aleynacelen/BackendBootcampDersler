using System;

namespace class_proporty;

public class Kisi
{
    public Kisi(string ad, string soyad, DateTime dogumTahrihi)
    {
        Ad = ad;
        Soyad = soyad;
        DogumTahrihi = dogumTahrihi;
    }

    public string Ad { get; set; }
public string Soyad { get; set; }   
public DateTime DogumTahrihi { get; set; }  
public byte Yas// ReadOnly property
{
    get
    {
        return (byte)(DateTime.Now.Year-DogumTarihi.Year)

    }

}
public void BilgileriEkranaYaz()
{
    System.Console.WriteLine($"ad:{Ad}\nSoyad {Soyad}\n yAS{Yas}");

}


}
