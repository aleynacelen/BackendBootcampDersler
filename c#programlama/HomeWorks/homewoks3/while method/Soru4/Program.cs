namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("bir metin giriniz");
        string input = Console.ReadLine();
        strging reversedText=" ";
        int index input.Lenght -1;
        while(index >= 0)
        {

            reversedText += input[index];
            index--;

        }
        Console.WriteLine("TERSİNE ÇEVİRİLEN METİN : " + reversedText);
    }
}
