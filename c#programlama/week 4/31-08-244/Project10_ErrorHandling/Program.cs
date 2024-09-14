namespace Project10_ErrorHandling;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("merhaba");
        #region Try Catch System

        try
        {
            
        }
        catch (System.Exception)
        {
            
            throw;
        }
            
        #endregion

        #region Try Catch
        Console.Write("1.sayı");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("2.sayı");
        int number2 = int.Parse(Console.ReadLine());
        int result = number1 / number2;
        Console.WriteLine(result);

        #endregion
    }
}
