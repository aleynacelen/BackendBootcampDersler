using System;
using System.Collections.Generic;
using System.Linq;
// public class Category
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public bool IsDeleted { get; set; }
// }
// class Program
// {
//     static void Main(string[] args)
//     { 
//         List<Category> categories = new List<Category>
//         {
//             new Category{Id=1,Name="Elektronik",IsDeleted=false},
//             new Category { Id = 2, Name = "Mobilya", IsDeleted = false },
//              new Category{Id=3,Name="Giyim",IsDeleted=false}
//         }; 

//        var IsDeletedCategories= categories
//                 .Where(c=>!c.IsDeleted)
//                 .ToList();

//         var IsDeletedCategoriesQuery =from category in categories
//                                     where !category.IsDeleted
//                                     select category;




//     }

// }

// using System;
// using System.Collections.Generic;
// using System.Linq;
// public class Category
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public int Price {get;set;}

// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         List<Category> categories = new List<Category>
//         {
//             new Category{Id=1,Name="Elektronik",Price=10},
//             new Category { Id = 2, Name = "Mobilya", Price=10 },
//              new Category{Id=3,Name="Giyim",Price=20}
//         };

//         var ProductPrice =categories
//                 .Select(c=>c.Price)
//                 .ToList();

//         var ProductPriceQuery= from category in categories
//                                 select category.Price;




//     }

// }


//Co












//IEnumerable Nedir ?
//IEnumarable koleksiyonların temel arayüzlerinden biridir
//Salt okunabilirdir
//Foreach ile kullanılır
//Tembel yükleme (lazy loading) yapar, yani tüm elemanları belleğe yüklemeden çalışabilir

// using System;
// using System.Collections.Generic;
// class Program
// {
//     static void Main()
//     {
//         List<string> animal = new List<string>{"kedi","köpek","kuş",};
//         IEnumerable<string> enumarableNames =animal;

//         foreach (var animals in enumarableNames)
//         {
//             System.Console.WriteLine(animals);

//         }

//     }


// }

// using System;
// using System.Collections.Generic;
// class Program
// {
//    static void Main(string[]args)
//    {
//     ICollection<string> sehirler =new List<string>{"Bursa","İstanbul","Antalya","Mersin"};





//     foreach (var şehir in sehirler)
//     {
//        System.Console.WriteLine(şehir); 
//     }




//    }
// }
//Iqueryable : sql sorgularını ve lınq ile yazarken verileri yalnızca ihtiyac duyulduduğunda sorgulanmasını sağlar  bu veritabanında büyük veri setleri ile çalışırken performans avantajı sağlar IQuerable verileri sadece gerektiğinde alınmasını ve daha verimli şekilde illenmesini sağlar

// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Veritabanına benzer bir koleksiyon oluşturuyoruz
//         List<Product> products = new List<Product>
//         {
//             new Product { Id = 1, Name = "Laptop", Price = 1500 },
//             new Product { Id = 2, Name = "Telefon", Price = 700 },
//             new Product { Id = 3, Name = "Tablet", Price = 400 },
//             new Product { Id = 4, Name = "Kamera", Price = 1200 }
//         };

//        IQueryable<Product> queryableProducts = products.AsQueryable();
//        var expensiveProducts = queryableProducts
//                             .Where(p=>p.Price>500);
                            
//     }
// }

// class Product
// {
//     public int Id { get; set; }
//     public string Name { get; set; }
//     public double Price { get; set; }
// }

//Projeye EF cORE UYGULAMAK İÇİN ADIMLAR:
//1) Microsoft.EntityFrameworkCore.Sqlserver paketini kur - DbContect  sınıfından miras alan contexr sınıfı oluştur-Entity sınıflarını oluştur (Category ,Product,Project)
//context içerisinde oNcONFİGURİNG METODUNU OVERRİDE EDEREK ConnectionString bilgisini base class (DbContext')a gönder
//dotnet ef migrations add MigrotionName komusu ile migration oluştur 
//dotnet ef database update ile ilgiki migrationdaki işlemleri veritabanına 
