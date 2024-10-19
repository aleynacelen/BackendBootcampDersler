namespace Soru2;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("pozitif sayı gir:");
       int n = int.Parse(Console.ReadLine());
       
       for(int i=1; i<=n ; i++)
       {
        int cube = i*i*i;
        Console.WriteLine(cube);

       }
    }
}
