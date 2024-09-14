using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Project15;

class Program
{

    //<Erişim belirleyici > <geri dönüş tipi> Method Adı (parametre1tipi parametre1adı parametre2tipi parametreadı ...)
    // {    
   //  method gövdesi işlemler burada gerçekleşir  return (geri döndürülecek değer)}
   // return keywoedu sadece method gerşye bir değer döndürecekse kullanılır
   // void ifadesi geriye birşey döndürmeyecek tümdürz yazacak
   // DRY (Dont Reat Yourself)-> 

static void Greet()
{
    Console.WriteLine("Merhaba Drogba");

}

static string  Greet2(string name , bool gender)
{
    if(gender)
    {
        return $"Merhaba {name} hanım :)";
        

    }
   
    
        return $"merhaba{name } bey :)";
        

    

}

static int Sum1()
{
    int a = 49;
    int b=50;
    int c= a+b;
    return c;


}
    static int Sum2(int number1, int number2)
    {
int result = number1+ number2;
return result;
    }

    static double SumSqrt(double number1 , double number2)
    { double total = number1 + number2;
    double result= Math.Sqrt(total);
    return result;

    }


static void SampleNumberValue( ref int originalNumber)
{ originalNumber +=3;
Console.WriteLine($"Metodun içindeki {originalNumber}");




}

static void Bolme (int bolunen, int bolen, out int bolum, out int kalan)
{
    bolum = bolunen/bolen;
    kalan = bolunen % bolen;
}


    static void Main(string[] args)
    {
        int bolum;
        int kalan;
        Bolme(8, 3, out bolum, out kalan)

        Console.WriteLine($"8/3={bolum}\n8/3 işleminden kalan {kalan}");

    //    Greet();

//    int x = Sum1();
//    int y = Sum2(50,70);
//    int z = Sum2(90,250);
//    Console.WriteLine(x+y+z);
        // double result1 = SumSqrt(4,12); //4
        // double result2 = SumSqrt(5, 11);//4
        // double result3 = SumSqrt(2, 23);//5
        // double result4 = SumSqrt(7, 42);//7
        // Console.WriteLine(Greet2("Tuna", true ));
        
        // int originalNumber= 15;
        // Console.WriteLine($"Metot çağırılmadan önceki originalNumber deüeri:{originalNumber}");
        // SampleNumberValue(ref originalNumber);

        // Console.WriteLine($"Metot çağırıldıktan sonra ki originalNumber {originalNumber}");


    }

    
}
