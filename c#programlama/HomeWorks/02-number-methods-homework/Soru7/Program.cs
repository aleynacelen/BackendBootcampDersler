namespace Soru7;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Derece cinsinden bir açı girin: ");
        double angle = double.Parse(Console.ReadLine());
        double angle2 = angle*(Math.PI/180);
        Console.WriteLine(angle2);
    }
}
