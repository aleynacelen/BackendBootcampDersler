// // // System.Console.WriteLine("1.işlem(5sn)");
// // // for (int i = 1; i <= 5; i++)
// // // {
// // //     System.Console.WriteLine($"\r[1.İşlem]Geçen süre {i}sn");
// // //     Thread.Sleep(1000);
// // // }
// // // System.Console.WriteLine("1. işlem (5 saniye ) sona erdi");
// // // \r  karakteri satır basına dönerek aynı satırı güncellemek için kullanılıyor  
// // //yeni bir satır eklemek yerine mevcut olan satırı değiştiriyor
// // //thread.sleep(1000) 1 saniye bekliyor
// // // for (int i = 1; i <= 5; i++)
// // // {
// // //     System.Console.WriteLine($"[1.İşlem]Geçen süre {i}sn");
// // //     Thread.Sleep(1000);
// // // // }
// // // // System.Console.WriteLine("1. işlem (5 saniye ) sona erdi"); 
// // // Thread thread1 = new Thread(() =>
// // // {
// // //     for (int i = 1; i <= 5; i++)
// // //     {
// // //         lock (consoleLock)
// // //         {
// // //             task1Status = $"5 saniyelik işlem için geçen süre: {i} sn";
// // //             Console.Clear();
// // //             System.Console.WriteLine($"{task1Status}\n{task2Status}");
// // //         }
// // //         Thread.Sleep(1000);
// // //     }
// // //     lock (consoleLock)
// // //     {
// // //         task1Status = "5 saniyelik işlem tamamlandı!";
// // //         Console.Clear();
// // //         System.Console.WriteLine($"{task1Status}\n{task2Status}");
// // //     }
// // // });


// // abstract class Product
// //  {
// //     public int Id { get; set; }
// //     public string Name { get; set; }
// //     public abstract decimal CalculateDiscount ();

// // }

// // //Abstract bir soyut sınıftır doğrudan örneklenemez 
// // //İçinde hem soyut hem de somut metotlar bulunabilir
// // //abstract metotlar bu sınıfı miras aşan alt sınıflar tarafından zorunlu olaarak uygulanmalıdır

// // // bu yapıda  ıd ve name gibi tüm ürünlerin ortak özellijlerini içeriyor 
// // //calculatediscount metdoy soyut olarak tanımlanmış cunku her ürün tipine göre farklı idirim  hesaplama yöntemi uygulanacak 

// // // eğer peridod 2 yıldan uzun ise irim %10 olsun  aksi halde %5

// // class Electronic :Product
// // {
// // public int Period {get;set;}
// //     public override decimal CalculateDiscount()
// //     {
// //         if (Period>2)
// //         return 0.10m;  //%10 indirim
// //         else
// //         return 0.05m;
// //     }
// //     class Program
// //     {
// //         static void Main(string[] args)
// //         {
// //             Electronic laptop = new Electronic
// //             {
// //                 Id = 1,
// //                 Name = "Laptop",
// //                 Period = 3 // 3 yıl garantili
// //             };

// //             Console.WriteLine($"Product: {laptop.Name}, Discount: {laptop.CalculateDiscount() * 100}%");
// //         }
// // //     }
// // using System.Net.Http.Headers;

// // interface IProductRepository 
// // {
// //     Product GetProductById(int id);
// //     List<Product> GetAll();

// // }


// abstract class Product
// {
//     public int Id { get; set; }
//     public string Name { get; set; }

//     public abstract decimal CalculateDiscount()


// }
// class Electronic :Product 
// // {
// //     public int Period {get;set;}
// //     public override decimal CalculateDiscount()
// //     {
// //         throw new NotImplementedException();
// //     }

// // }
// // class Food : Product
// // {
// //     public DateTime ExpirationDate{get;set}
// //     public override decimal CalculateDiscount()
// //     {
// //         throw new NotImplementedException();
// //     }
// // }

// // /*
// // linq c# gibi dillerde verileri sorgulamak ve dönüştürmek içi kullanılır
// // *\
// // //1. Örndeğimizde  bir dizide çift sayıları bulmak : başlangıç olarak bir dizi üzerinde where metoduna çalışacağız

// // using System;
// // using System.Globalization;
// // using System.Linq;
// //  class Program
// //  {
// //     static void Main()
// //     {
// //         int[] numbers ={1,2,3,4,5,6,7,8,9,20};
// //         //METHOD SYNTAX KULLANARAK ÇİFT SAYI BULMA!!!
// //         var evenNumbers = numbers.Where(x=>x %2==0);
// //         //AYNI İŞLEMİ QUERY SYNTAX KULLANARAK :
// //         var evenNumbersQuery = from num in numbers  
// //                                 where num %2==0
// //                                 select num;
// //         Console.WriteLine("Çift Sayılar (Method Syntax:)");
// //         foreach (var num in evenNumbers)

// //         {
// //             Console.Write(num + " ");
// //         }
// //         System.Console.WriteLine("\nÇift Sayılar(query syntax):");
// //         foreach (var num in evenNumbersQuery)
// //         {
// //             System.Console.WriteLine(num+" ");
// //         }

// //     }

// // }
// //ŞİMDİ SIRALAMALARA GEÇEBİLİRİZ
// //OrderBy : Küçükten büyüğe sıralar 
// //OrderByDescending : Büyükten küçüğe sıralar

// // // using System;
// // // using System.Linq;
// // // using System.Runtime.InteropServices.Marshalling;
// // // class Program 
// // // {
// // //     static void Main()
// // //     {
// // //         int[] numbers ={10,5,8,3,7,2,6};

// // //         //METHOD SYNTAX İLE KÜÇÜKTEN BÜYÜĞE SIRALADIK

// // //         var ascendingOrder = numbers.OrderBy(x=>x);

// // //         //BÜYÜKTEN KÜÇÜĞE SIRALADIK

// // //         var descendingOrder = numbers.OrderByDescending(x=>x);

// // //         foreach (var num in ascendingOrder)
// // //         {
// // //            Console.Write(num+" ");
// // //         }
// // //         System.Console.WriteLine("\nSıralama(küçükten büyüğe-Methodsyntax ile)");

// // //         foreach (var num in descendingOrder)
// // //         {
// // //             Console.Write(num+" ");

// // //         }
// // //         System.Console.WriteLine("\nSıralama(büyükten küçüğe MethodSyntax ile)");

// // //     }
// // // // }
// // // using System;
// // // using System.Globalization;
// // // using System.Linq;

// // // static void Main()
// // // {
// // //     int [] number={10,2,3,4,5,5,6};
// // //     var ascendingOrderQuery = from num in number
// // //                                 orderby num
// // //                                 select num;
// // //     var descendingOrderQuery= from num in number
// // //                                 orderby num descending
// // //                                 select num;
// // //     System.Console.WriteLine("\nSıralama(küçükten büyüğe query)");
// // //     foreach (var num in ascendingOrderQuery)
// // //     {
// // //         Console.Write(num+" ");
// // //     }
// // //     Console.WriteLine("\nSıralama (Büyükten Küçüğe - Query Syntax):");
// // //     foreach (var num in descendingOrderQuery)
// // //     {
// // //         Console.Write(num + " ");
// // //     }
// // // }
// // using System;
// // using System.Linq;
// // using System.Collections.Generic;

// // class Program
// // {
// //     static void Main()
// //     { 
// //         List<Student> students= new List<Student>
// //         {
// //             new Student {Id=1,Name="Ceren",Grande=85,Age=18} ,
// //             new Student {Id=2,Name="Fatma",Grande=85,Age=18}, 
// //             new Student {Id=3,Name="Cisem",Grande=85,Age=18}, 
// //             new Student {Id=4,Name="Ayşen",Grande=85,Age=18} ,
// //             new Student {Id=5,Name="Faruk",Grande=85,Age=18}
// //         };
// //         //method syntax ile
// //          var selectedStudentMethod =students
// //             .Where(s=>s.Grande>=90)
// //             .Select(s=> new{s.Name,s.Grande});
// //         //query syntax ile
// //         var selectedStudentMethodQuery =from s in students
// //                                         where s.Grande >=90
// //                                         select new {s.Name,s.Grande};
// //         foreach (var student in selectedStudentMethod)
// //         {
// //             System.Console.WriteLine($"Ad{student.Name}, Not:{student.Name}");
// //         }
// //         System.Console.WriteLine("Seçilen öğrenciler ");
// //         foreach (var student in selectedStudentMethodQuery)
// //         {
// //             System.Console.WriteLine($"adı:{student.Name},notu:{student.Grande}");
// //         }

// //     }
// // }
// // class Student
// // {
// //     public int Id { get; set; }
// //     public string Name { get; set; }
// //     public int Grande { get; set; }
// //     public int Age { get; set; }
// // }


// using System;
// using System.Linq;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         // Öğrenci listesi
//         List<Student> students = new List<Student>
//         {
//             new Student { Id = 1, Name = "Ayşe", Grade = 85, Age = 18 },
//             new Student { Id = 2, Name = "Mehmet", Grade = 90, Age = 20 },
//             new Student { Id = 3, Name = "Ceren", Grade = 95, Age = 21 },
//             new Student { Id = 4, Name = "Selim", Grade = 75, Age = 20 },
//             new Student { Id = 5, Name = "Gül", Grade = 95, Age = 19 }
//         };

//         var groupedByAge = students
//         .GroupBy(s=>s.Age)
//         .OrderBy(g=>g.Key); //Yaşlarını büyükten küçüğe sırala
//         foreach (var group in groupedByAge)
//         {
//             System.Console.WriteLine($"Yaş:{group.Key}");
//             foreach (var student in group)
//             {
//                 System.Console.WriteLine($"Ad: {student.Name}");
//             }
//             System.Console.WriteLine();//boşluk için
//         }

//     }
// }
// class Student
// {
//     public int Id { get; set; }
//     public string Name {get;set;}
//     public int Grade { get; set; }
//     public int Age { get; set; }

// }

using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Öğrenciler
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Ayşe" },
            new Student { Id = 2, Name = "Mehmet" },
            new Student { Id = 3, Name = "Ceren" }
        };

        // Dersler
        List<Course> courses = new List<Course>
        {
            new Course { StudentId = 1, CourseName = "Matematik" },
            new Course { StudentId = 2, CourseName = "Fizik" },
            new Course { StudentId = 3, CourseName = "Kimya" },
            new Course { StudentId = 1, CourseName = "Kimya" }
        };
    }
















