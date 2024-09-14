namespace Project16;

class Program
{

    static int Sum(int a, int b)
    {
        return a+b;

    }
    static int Sum(int a, int b, int c)
    {
        return a + b +c ;

    }
    static int Sum(int a, int b, int c, int d)
    {
        return a + b + c+ d;

    }

    static void Greet(String name, byte age)
    {
        Console.WriteLine($"MERHABA {age}yaşındaki {name}");
    }
    static void Greet(String age byte name)
    {
        Console.WriteLine($"MERHABA {age}yaşındaki {name}");
    }


    static string GetCoffe(string coffeType, int quantitySugar=0, bool withMilk=true)
    
    {
      string coffe =$"{coffeType}kahve";
      coffe+= quantitySugar >0 ? $", {quantitySugar}": "şekerli";
      if(withMilk){
        coffe+= " , sütlü";

      }
      else{
        coffe+= ", sade";
      }
      coffe = "KAHVENİZ HAZIKR";


    }



    static void Main(string[] args)
    {
        // Console.WriteLine(Sum(5,7));
        // Console.WriteLine(GetCoffe("Americano", 0));

        // Greet("Engin", 49);

        Console.WriteLine(GetCoffe("Americano"));
    }
}
