namespace ConsoleApp1;

class FirstClass
{
    // Buraya sınıfın özellik ve davranışlarını kodluyor olacağız.
    // Özellik: Property
    //Davranış: Method
    public string message;//özellik oldu
    string age;
    public void DisPlayMessage()//public olmaı dışarıda da kullanabilmemeii sağlıyor //public ve private bunlar erişim belirleyiciler
    //Bu klastan yaratılan bir nesnede kullanılabılen demek (public) //morlar method maviler proporty
    {
        System.Console.WriteLine(message);
        
    }
}










class Program  // program yazan kısım class kısmımız //objeyı yaratırken  kullandığım bir şablon //objeye ait özellik ve davranışlardan bahs ederiz 
{
    static void Main(string[] args)
    {
        FirstClass firstClass1 = new FirstClass();
        firstClass1.message= "selam";
        // System.Console.WriteLine(firstClass1.message);
        firstClass1.DisPlayMessage();
    }
}
