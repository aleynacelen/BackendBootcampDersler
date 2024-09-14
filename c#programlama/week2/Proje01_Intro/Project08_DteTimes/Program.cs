using System.Net.Http.Headers;

namespace Project08_DteTimes;

class Program
{
    static void Main(string[] args)
    {
     // Tarih ve saatlerle çalışmak için DateTime adında bir sınıf vardır.
    //  DateTime now = DateTime.Now;
     
    // //  Console.WriteLine($"3 hafta sonraki tarih {now.AddDays(21)}");
    // //  Console.Writeline($"3 ay sonraki tarih{now.AddMonths(3)}");
    // System.Console.WriteLine(now.ToString("dd/MM/yyyy"));
    // Console.WriteLine(now.ToString("HH:mm:ss"));
    // Console.WriteLine(now.ToString("d"));
    // Console.WriteLine(now.ToString("MMMM yyyy"));
    // Console.WriteLine(now.ToShortDateString());
    // Console.WriteLine(now.ToShortTimeString());
    // int day = 5;
    // int month = 6;
    // int year = 1988;
    // DateTime date = new DateTime(year,month,day,4,5,0 );
    // Console.WriteLine(date);
    // Console.WriteLine(date.AddMonths(-3));
    
    DateTime birthDate = new DateTime(1975,7,16);
    int month = birthDate.Month;
    Console.WriteLine(birthDate.Month);
        DateTime now = DateTime.Now;
        Console.WriteLine(now.DayOfWeek);





    }
}
