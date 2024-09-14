namespace Project17;

class Program
{

    // kendisine gönderilen int tipindeki sayı sizinde yer alan negatif sayıları geri döndüren bir metod yazınız


    static List <int> GetNegativeNumbers(List<int> numbers)
    {

        List<int> negativeNumbers = new List<int>();
       foreach (var number in numbers)

       
       {
        if(number<0)
        {
                negativeNumbers.Add(number);

            }

       }
        return negativeNumbers;



    }

    static int GetTotalSquareNumbers(int a, int b)
    {
        int TotalOfSquaers = (a*a )+ (b*b);
        return TotalOfSquaers;
        

    }


    static void Main(string[] args)
    {
    //    List<int> numbers = [5,7,8,-4,-12,4,7];
    //    List<int> resultNumbers = GetNegativeNumbers(numbers);
    //    foreach (var number in resultNumbers)
    //    {
    //     Console.WriteLine(number);
    //    }

    
// Console.WriteLine(GetTotalSquareNumbers(3,5));
    }
}
