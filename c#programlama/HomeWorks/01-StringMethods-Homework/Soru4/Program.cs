namespace Soru4;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir cümle giriniz");
        string cümle = Console.ReadLine();
        string trimmedText = cümle.Trim('# ', ' * ');
        Console.WriteLine(trimmedText);

        

    }
}
