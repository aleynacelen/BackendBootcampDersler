 //Eticaret sistemi var Ürünlerin fakrlı tipleri olabilir her ürürnün temel özelllşkleri aynıdır bazıları  zöellikleri tipe göre değişkendlik gösteir bu dudumra üst sınıf olarak palanlayacağımız product bir abstract class olacaktır
 // interface** 

 abstract class Product{
    public int Id { get; set; }
    public string? Name { get; set; }

    public abstract MyProperty { get; set; }

 }
 class Electronic : Product
 {
 public int WarrantyPeriod { get; set; }
throw new NotUmplementedExpection();

 }
