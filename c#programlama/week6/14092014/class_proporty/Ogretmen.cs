using System;

namespace class_proporty;

public class Ogretmen : Kisi
{
    public Ogretmen(string ad, string soyad, DateTime dogumTahrihi) : base(ad, soyad, dogumTahrihi)
    {
        public string Brans { get; set; }   

        decimal maas;
        public decimal Maas
        {
        get
        {
            return Maas;
            

        }
        set
        {
            if(value<0)
            {
                throw new ArgumentException("negatif bir maas bilgisi olamaz!");

            }
            maas=value;

        }

        }


    }
    public overide void BilgileriEkranaYaz()
}
