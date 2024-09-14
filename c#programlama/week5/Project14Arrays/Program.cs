using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;

namespace Project14Arrays;

class Program
{
    static void Main(string[] args)
    {
        // int[] numbers;
        // numbers = new int[5];
        // numbers[0]=45;
        // numbers[1]=455;
        // numbers[2] = 1455;
        // numbers[3] = 4515;
        // numbers[4] = 41255;

        // for (int i=0; i<5; i++)
        // { 
        //     Console.WriteLine($"dizinin {i+1}. elemanı{numbers[i]}");

        // }


        // int[] numbers = {49,34,90,67,44}; //Boyutu 5 new int[5] demiş gibi oluyoruz
        // string [] studentNames = {
        //     "ali",
        //     "ahmet",
        //     "murat",


        // };
        // for (int i =0 ;i <studentNames.Leght; i++)
        // {
        //     studentNames[i]+= "Canoğlu";
        // }
        // for (int i = 0; i < studentNames.Leght; i++)
        // { Console.WriteLine(studentNames[i]);

        // }

        // int[] numbers = { 49, 34, 90, 67, 44 }; //Boyutu 5 new int[5] demiş gibi oluyoruz
        // string[] studentNames = {
        //     "ali",
        //     "ahmet",
        //     "murat"};
        //     foreach (string student in studentNames)// 1. tipi 2. içinde olan 3. dizinin adı

        //     {
        //         Console.WriteLine(student);
        //     },

        // int [] prices={40,50,60,70,80};
        // prices dizisinin içindeki fiyatlara  yüzde  10 zam gelmiştir zamlı fiyatları içericek şekilde  price dizisnini güncelleyerek kodu yazınız

        int[] prices = { 40, 50, 60, 70, 80 };
        // for (int i = 0; i < 5; i++)
        // {
        //     Console.WriteLine($"dizinin {i + 1}. elemanı{prices[i]}");
        // };
        // for (int i =0 ;i <studentNames.Leght; i++)
        //  {
        //      studentNames[i]+= "Canoğlu";
        //  }
        // for (int i = 0; i < studentNames.Leght; i++)
        //  { Console.WriteLine(studentNames[i]);

        // Console.WriteLine("zamsiz ürün fiyatları");
        // Console.WriteLine("---------------------------");
        // foreach (int p in price)


        // {
        //     Console.WriteLine(p);

        // }
        // for(int i =0; i<prices.Length;i++)
        // {
        //     prices[i]= (int)(prices[i]*1.1);


        // }
        // Console.WriteLine("zamlı ürün fiyarı");



        // a=40 b=50 c=45 şeklinde elimizde bulunan üç sayıdan en büyüğünü bulduran kodu yazınız.
        // int a=40;
        // int b=50;
        // int c=45;

        // int max = int.MinValue;
        // if(a<max)
        // {
        //     max=a;

        // }
        // if(b>max)
        // {
        //     max=c;

        // }

        // Random rnd = new Random();
        // int[] numbers = new int[20];
        // for (int =0; int<numbers.Length; int++)
        // {
        //     numbers [i]= rnd.Next(1,1001);
        //     Console.WriteLine($"in ")
        // }


        // string text = "Macbook ile Yazolom Geliştirme Ortamının Hazırlanması";
        // string [] result = text.Split();
        // Console.WriteLine(result[0]);


        // string text = "çok hava çok güzel çok";
        // string[] result = text.Split("çok");
        // int wordCount = result.Length-1;
        // Console.WriteLine(result[0]);
     //DİZİLERİ KOPYALAMAK
    //  string[] names = {"Ayşen", "Umay","Ceyda","Begüm"};
    //  string [] newNames = new  string [names.Length];
    //  Array.Copy(names,newNames,4);

//DİZİNİN BOYUTUNU ELEMAN SAYISINI DEĞİŞTİRMEK
// int[] numbers = {3,6,8};
// Console.WriteLine(numbers.Length);

// Array.Resize(ref numbers,4);// 4 yerime numbers.Lenght+1 yazabiliriz!
// numbers[3]=55; // aralık dışı bir index girin
// Console.WriteLine(numbers.Lenght);

//DİZİNİN BELİRLİ BİR BÖLÜMÜNÜ TEMİZLEMEK

// int[] numbers = {4,5,6,7,8,9,};
// Console.WriteLine("dizinin orjinal hali");
// foreach (int number in numbers)
// {
//     Console.WriteLine(number);
    
// }
// Array.Clear(numbers,5);
//         Console.WriteLine("dizinin temizlenmiş hali");
//         foreach (int number in numbers)
//         {
//             Console.WriteLine(number);

//         }



string[] students = 
{ "HAKAN ÇAKDI",
"TUNACAN EKŞİ",
"ROJİN ÇETİZ",
"ELİF ÖZTÜRK",
"ENES KILIÇASLAN",
"ATLAS UYAR"


};
 string[] teamName = 
 {"debuggers",
 "CodeWars",
 "Algoritmiks",
 "BinaryC",
 "NullPointers",
 "devdDy"

 };
 int memberCount = 4;
 int teamCount = (int)Math.Ceiling.(students.Length/memberCount);

 string [] teams = new string[teamCount];

 Random rnd = new Random();
 int randomIndex;
 for (int i =0; i<students.Length; i++)
 
  {
    randomIndex= rnd.Next(students.Length);//7
    string temp=students[i];
    students[i]=students[randomIndex];
    students[randomIndex]= temp;



 }
int teamCounter = 0;
 string currentTeamName;
for(int i=0; i<students.Length ; i+=4)
{
currentTeamName = teamNames[0];
}













//  foreach(string s in students)
//  {
//     Console.WriteLine(s);

//  }





























    }
}
