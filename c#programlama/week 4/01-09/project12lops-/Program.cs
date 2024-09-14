using System.Formats.Asn1;

namespace project12lops_;

class Program
{
    static void Main(string[] args)
    {
        //    int total = 0;
        //    while (total<=100)
        //    {
        //     Console.WriteLine("bir sayı giriniz");
        //     int inputNumber = int.Parse(Console.ReadLine());
        //     total += inputNumber;
        //    }
        //    Console.WriteLine(total);



        // sadece sayı girişi yaptırLIM
        // ConsoleKeyInfo number ;
        // string resultNumber="";
        // Console.Write("Bir sayı giriniz:");
        // do
        // {
        // number = Console.ReadKey();
        // if(number.Key==ConsoleKey.Backspace)
        // {
        //     bool control =int.TryParse(number.KeyChar.ToString(), out int value);
        //     if(control)
        //     {
        //     resultNumber += number.KeyChar.ToString();
        //     }
        //     else{


        //     }

        // }

        // } while (number.Key!=ConsoleKey.Enter);//enter tuşundan farklı olduğu takritde başlasın
        ConsoleKeyInfo character; // rakam mı değilmi kontrol edebilmem için karakter girişi yaptırdım başta tanımlamamın sebebi : içinde olsaydı calışmazdı cunku parantezın dışındakı de tanısın onu  
        string resultNumber = ""; //kendi ihtiyacıma göre değiştireceğim bu yüzden değeri ekranda gösterip onu değerin içinde tutabileyim
        Console.Write("Bir sayı giriniz: ");
        do
        {
            character = Console.ReadKey(true); //sayı girişini sağlamak için ve sayının dışında birşeye de basmış olabilir ben ona müdahale edicem ve ekranda gözükmeyecek bu yüzden bu satırı yazdım //
            if (char.IsDigit(character.KeyChar))
            {
                resultNumber += character.KeyChar.ToString();
                Console.Write(character.KeyChar.ToString());
            }
            else
            {
                if (character.Key == ConsoleKey.Backspace && resultNumber.Length > 0)
                {
                    resultNumber = resultNumber.Substring(0, resultNumber.Length - 1);//58745 =>5874
                    Console.Write("\b \b");
                }
            }
        } while (character.Key != ConsoleKey.Enter); // enter a basmadığı sürece girmesine izin veriyorum
                                                     //asal sayı olup olmadığını bulma
                                                     // bool isPrime = true;
                                                     // Console.Write("bir sayı giriniz");
                                                     // int number=int.Parse(Console.ReadLine());
                                                     // if (number <=1)
                                                     // { 
                                                     //     isPrime=false;


        // }
        // else
        // {
        //     for (int i=2; i<number-1;i++)

        //     {
        //         if (number %i==0)
        //         { 
        //             isPrime=false;
        //             break;

        //         }

        //     }

        // }
//         // Console.WriteLine(isPrime == true ?"Asal" :"Asal değil.");

//         bool isPrime = true;
//         Console.Write("bir sayı giriniz");
//         int number = int.Parse(Console.ReadLine());
//         if (number <= 1)
//         {
//             isPrime = false;


//         }
//         else
//         {
//             for (int i = 2; i < number - 1; i++)

//             {
//                 if (number % i == 0)
//                 {
//                     isPrime = false;
//                     break;

//                 }

//             }

//         }


//         Console.WriteLine(isPrime == true ? "Asal" : "Asal değil.");
//         Console.Write("tekrar denemek ister misiniz");
//         AsnWriter = Console.ReadLine();
//         while (answe!"h");
        
        
        
        
        
        
        
        
//         bool isPrime = true;




//  Console.Write("bir sayı giriniz");
//  int number = int.Parse(Console.ReadLine());
//  while














    }
}
