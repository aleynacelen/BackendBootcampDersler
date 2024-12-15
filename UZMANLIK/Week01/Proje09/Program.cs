//LINQ (Language Integrated Query): C# Prıgramlama dilinde veri sorgulama  ve dönüştürme işlerimlerini basitleştirlen çok güclü bir özelliktir Amaç farklı veri kaynaklarından sorgulama yapmayı kolaylaştırarak standart ve daha okunabililir hale getirmektir
//Temel Özellikler
//1-SYNTAX(SÖZ DİZİMİ) BÜTÜNLÜĞÜ
//2-TİP GÜVENLİĞİ
//3-PERFORMANS ARTIŞI


//NOT: BAZI DURUMLAR İÇİN LIN@ TERCİH EDİLEMEYEBİLİR  İLERLEDİKÇE BU DURUMLARA ÖRNEK SENERYALARLA ÇALIŞACAĞIZ!
//Link Türleri:
// 1) LINQ to object
// 2) LINQ to Entities
// 3)LINQ TO XML
// 4) LINQ TO dataset

//Method Syntax
// int[] numbers=[1,2,3,4,5,6,7,8,9,10];
// var result1 = numbers.Where(x=>x%2==0);

// var result2 = numbers.OrderBy(x=>x); // orderbydescending tersten sıralar

//  var result3 = numbers.Select(X=>X*X);

// foreach (var number in numbers)
// {
//     System.Console.WriteLine(number);
// }

// //Quary Syntax
// var result4 = from number in numbers
//               where number%2 == 0
//               select number;

//Lınq to Object
// using System.Security.Cryptography.X509Certificates;

// List <Student> students=[
//     new Student{Id=1,Name="Ayşen",Age=18,Grade=85},
//      new Student{Id=2,Name="Ayşen",Age=18,Grade=85},
//       new Student{Id=3,Name="Ayşen",Age=18,Grade=85},
//        new Student{Id=4,Name="Ayşen",Age=18,Grade=85},
//         new Student{Id=5,Name="Ayşen",Age=18,Grade=85}
// ];
// var result =students.Where(x=>x.Grade<=90).OrderBy(x=>x.Name);
// foreach (var s in result)
// {
//     System.Console.WriteLine($"{s.Name}: {s.Grade}");
    
// }
// var resultQuary =from student in students
//                     where student.Grade >= 90
//                     orderby student.Name
//                     select student;
                    
// foreach (var item in resultQuary)
// {
//     System.Console.WriteLine($"{s.Name}: {s.Grade}");
// }
//Linq to Arrys
//ilk yazdığımız kodlar buna örnek!!


 class Student
 {
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Grade { get; set; }
 }
