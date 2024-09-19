using System;

namespace ConsoleApp3;

public class Ogrenci:Kisi
{
    public Ogrenci(int ogrenciNo)
    {
        OgrenciNo = ogrenciNo;
    }

    public Ogrenci (string ad, string soyad ,DateTime dogumTahrihi): base(ad,soyad,dogumTahrihi)
{
    public int OgrenciNo { get; set; }k
}
}
