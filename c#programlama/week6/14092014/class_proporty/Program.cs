using System.Reflection.Emit;
using System.Windows.Markup;

namespace class_proporty;

class Product
{
    // private int myVar;
    // public int MyProperty
    // {
    //     get { return myVar; }
    //     set { myVar = value; }
    // }
    public int Id { get; set; }
    public string? Name  { get; set; } //? koymamız demek ben null olabilceğini biliyorum demek

    public string Description { get; set; } 
    public decimal Price { get; set; }
    public bool isActive { get; set; }  


}

class Product
{

    int id ;
    string name;
    decimal price;
    bool isActive;
    // class içindeki bilgileri dışarıya konntrollu bir şekilde açılmasını sağlayan yapılara  property diyoruz yaptığımız bu işleme encapsulation diyoruz yani kapsülleme

    public string Name // şuan bir property oluşturuyoruz
    {
        get
        {
           string  result = name.Substring(0,3).ToUpper();
            return result();

        } //içindekini okumak
        set
        {
            name = value;

        }


    }

    public decimal Price
    {
        get
        {
            return price;

        }
        set
        {
            if(value<0)
            {
                price =0;

            }
            else
            {
                price=value;

            }
            // price = value<0 ?0:value;

        }

    }


}




class Student
{

    public Student ()
    {
        System.Console.WriteLine($ "{DateTime.Now} zamanında yeni bir Student Oluşturuldu");

    }
    public Student(int StudentNumber)
    {
        StudentNumber= StudentNumber;
        

    }
    public int StudentNumber { get; set; }  
    public string FirstName { get; set; }
    public string  Surname { get; set; }
    public bool isActive { get; set; }

    class Category
    
    {
        public Category(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }


}

class Program
{
    static void Main(string[] args)
    {


        Category
        Student s1 =new Student();
        Student s2 = new Student(48);
        System.Console.WriteLine();













        // Product product1 = new Product(){Notes="birşey"};
        // product1.Id=6;
        // product1.Price=800;
        // product1.Name="Macbook Air M2";


        // Product product1 = new Product(); //new keywordu heepte bir nesne oluştu
        // product1.Name = "İphone 14";
        // System.Console.WriteLine(product1.Name);

        // product1.Price=6000;
        // System.Console.WriteLine(product1.Price);
    }
}
