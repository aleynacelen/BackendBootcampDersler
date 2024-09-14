using System.Data.SqlTypes;

namespace Project11_Loops;

class Program
{
    static void Main(string[] args)
    {
        
        #region for
        // //    for(int counter=1;counter<=5;counter=counter+1)

        // //    {
        // //     Console.WriteLine($"{counter} . merhaba dünya");

        // //    } //1.den itibaren dönüceği için 1 ile başladım  3. kısımda counter bu döngüye başlarken 1 olucak ve devamında bir artıcak ortada yazdığımız kaç defa olucağı hakkında bilgi verir Döngü gövdesi : Döngü içerinde tekrar çalıştırmasını istediğim şey yazar 
        // //i ++ i=i+1; ( i nin değerinin bir artması) İ = i+3  i+=3


        // // #region for
        // // for (int i = 1; i <= 5; i = i + 1)

        // // {
        // //     Console.WriteLine($"{i} . merhaba dünya");

        // // } 

        // //bir ve 10 arasında sayılar yazınız sayı 1 ... gibi
        // // string message ;
        // //         for (int i = 1 ; i<=10 ; i++)
        // //         {
        // //             message=$"Sayi {i}:{i}";
        // //             Console.WriteLine(message);
        // //         }

        // // string message;
        // // int counter = 1;
        // // for (int i = 100; i <= 200; i++)
        // // {
        // //     message = $"Sayi {counter++}:{i}"; // ++counter olarak yazabilirim ama 0 dan başlatmam gerekir önce değiştir sonra kullan ilk değer 2 den başlamasın diye 0dan başlattım
        // //     // counter++;
        // //     Console.WriteLine(message);
        // // }
        // // 1-10 arasındaki çist sayıları ekrana yazıdr
        // // string message;
        // // for(int i = 2 ; i <=10 ; i+=2)
        // // {
        // //     message = $"{i}";
        // //     Console.WriteLine(message);

        // // }
        // // for (int i = 1; i <= 10; i++)

        // // {
        // //    if (1 % 2 == 0)
        // //    {


        // //    }

        // // Faktoriyelin değerini hesapla

        // //    Console.WriteLine("bir sayı giriniz");
        // //    int value = int.Parse(Console.ReadLine());
        // //    int factorial = 1 ;
        // //    for (int i = 2; i<= value; i++)

        // //    {
        // //     factorial *= i;
        // //    }
        // //    Console.WriteLine($"{value} ! = : {factorial}");




        // // }



        // #endregion

        // // int a =33;
        // // int b = a++ +3 ;
        // // Console.WriteLine(a);34
        // // Console.WriteLine(b);36 ilk önce kullan sonra değiştir dediği için değişmiş hali 34 oldu ama alt kısımda değişmemiş halini kullanmalıyım çünkü ilk önce değiştir sonra kullan 

        // #region While
        // // int i= 1;
        // // while (i<=5)
        // // {
        // //     Console.WriteLine($"{İ}. Hello World!");
        // //     i++;


            

        // // }
        // // int total = 0;
        // // string input =" ";

        // // while (input != "exit")
        // // {
        


        // // }
        // int total= 0;
        // string input = " ";
        // while (true)
        // {

        // }


        // #endregion
        


        
            int i = 1;

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 5);
        }
    }


