namespace Project13_GuessNumber;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int generatedNumber = rnd.Next(1,101);
        Console.WriteLine($"HİLE=> {generatedNumber}");
        Console.WriteLine("******************");
        Console.WriteLine();
        int guessNumber;
        int live =1;
        int liveLimit=5;
        string resultMessage = "";
        do
        {
            Console.Write($"{live}.Hak(1-100):");
            guessNumber= int.Parse(Console.ReadLine());
            if(guessNumber<generatedNumber)
            {
            resultMessage="Daha büyük bir sayı girimiz!";


            }else if(guessNumber>generatedNumber){
                resultMessage="Daha küçük bir sayı giriniz!";
            }
            if(guessNumber!=generatedNumber)
            {
                live++;
            }
            if(live<=liveLimit && guessNumber!=generatedNumber) Console.WriteLine(resultMessage);
            
        } while (guessNumber!=generatedNumber && live<=liveLimit);
        resultMessage=guessNumber==generatedNumber? $"kazandın  \nPuanın : {(liveLimit-live+1)*10}" : "kaybettin";
        Console.WriteLine(resultMessage);
        Console.WriteLine(resultMessage);
        Console.Write("Çıkış için ENTER");
        Console.ReadLine();
        while (guessNumber==generatedNumber && live > liveLimit)
        
        {
Console.WriteLine("Baştan Başlamak İster Misin (E/H) ");
string answer =Console.ReadLine();
        }
    }
}
/*
Sayı Tahmin Oyunu : Uygulamamızın rastgele üreteceği 1-100 arasındakı sayıyı kullanıcının tahmın ederek kbulacağı bir oyun yazacağız kullanıcının tahmini üretilen sayıdan büyük ve küçük olma durumuna göre yönlendıreceği bir program yazınız 5 tahmın hakkı verlerim doğru tahmınde veya 5 hakkı doldurduğunda oyun bitsin uygun mesajı versin
*/