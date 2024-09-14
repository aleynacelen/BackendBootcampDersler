// using System.Security.Cryptography.X509Certificates;

// namespace Project09_Conditions;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // if(5>14){Console.WriteLine("İşlem tamamlandı");}else{Console.WriteLine("Hata!");}
//         // Console.WriteLine("Uygulama sona erdi..");
//         // {
//         //     else if (x < 15)
//         // }

//         //Kullanıcının klavyeden gireceği yaş bilsigini alıp eğer reşit değilse "resişt değilsiniz , şu kadar x sene sonra reşit olacaksınız " eğer reşit ise "Giriş Yapabilirseniz yazdıan kodu hazırlayınız"

//         // Console.Write("Lütfen yaşınızı giriniz.");
//         // byte age = byte.Parse(Console.ReadLine());
//         // if(age>=18)
//         // {
//         //     Console.WriteLine("Giriş yapabilirsiniz");
//         // }
//         // else{Console.WriteLine($"Reşit değilsiniz.{18-age} yıl sonra reşit olacaksınız!");
//         // }
//         // //DRY- Dont repeat yourself!! != eşit değilse demek

//         // Console.Write("Adınızı giriniz");
//         // string fullname = Console.ReadLine();
//         // Console.Write("Yaşınızı giriniz");
//         // byte age = byte.Parse(Console.ReadLine());
//         // string resultMesaage = age >= 18 ? $"giriş yapabilirsin {fullname}": $"{18-age}yıl sonra gel {fullname}";
//         // Console.WriteLine(resultMesaage);

//         #region Switch
//         byte point =30;
//         byte resultPoint= 0;
//         switch (point)
//         {
//             case <45: //point kücükse 45den demek
//                     resultPoint=1;
//                     break;
//             case <55:
//                     resultPoint=2;
//                     break;
//             case<70:
//                     resultPoint=3;
//                     break;
//             case<85:
//                     resultPoint=4;
//                     break;
//             case<=100:
//                      resultPoint = 5;
//                      break;

//             default:
//             Console.WriteLine("Lüten 01-100 arasında not giriniz");
//             break;
//         }
//           if(point> 0 && point <= 100) {

//             Console.WriteLine(resultPoint);

//         // TryPare DÖNÜŞTÜRMEYİ DENİYOR !!!!



//         }

//         #endregion
//         Console.Write("Bir tarih giriniz(gg.aa.yyyy): ");
//         string inputDate = Console.ReadLine();
//         if (DateTime.TryParse(inputDate, out DateTime date))
//         {
//             DayOfWeek dayOfWeek = date.DayOfWeek; //DayOfWeek.Sunday
//             System.Console.WriteLine(date.ToLongDateString());
//             switch (dayOfWeek)
//             {
//                 case DayOfWeek.Saturday:
//                 case DayOfWeek.Sunday:
//                     System.Console.WriteLine("İyi tatiller!");
//                     break;
//                 default:
//                     System.Console.WriteLine("İyi çalışmalar!");
//                     break;
//             }
//         }
//         else
//         {
//             System.Console.WriteLine("Hatalı tarih formatı");
//         }


//         //Girilen tarihin hangi mevsime denk geldiğini bulup ekrana yazdıran kodu Switch yapısı kullanarak hazırlayınız.
//         Console.Write("Bir tarih giriniz(gg.aa.yyyy): ");
//         string inputDate = Console.ReadLine();
//         if (DateTime.TryParse(inputDate, out DateTime date));
//         DayOfWeek dayOfWeek = date. ye; //DayOfWeek.Sunday
//         System.Console.WriteLine(date.ToLongDateString());
//         switch (dayOfWeek)


{
   {



        DateTime now = DateTime.Now;
    
    System.Console.WriteLine(now.ToString("MM yyyy")); 
    System.Console.WriteLine(now.ToShortDateString());


}






}




    

