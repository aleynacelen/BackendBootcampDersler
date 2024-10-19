namespace HomeWorks6_8;


public class Person
{
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public virtual void BilgiYaz()
    {
        System.Console.WriteLine($"Adı:{Name}\nYası:{Age}");


    }
    public virtual void DerseKatılım()
    {
        System.Console.WriteLine($"{Name} derse katılım sağladı");
    }


} 

class Teacher : Person
{
    public Teacher(string name, int age, string konuOgret) : base(name, age)
    {
        KonuOgret = konuOgret;
    }

    public string KonuOgret { get; set; }
    public override void DerseKatılım()
    {
        base.DerseKatılım();
        System.Console.WriteLine("Öğretmen Derse Katıldı");
    }
}

class Student : Person
{
    public Student(string name, int age, int gradeLevel) : base(name, age)
    {
        GradeLevel = gradeLevel;
    }
    public int GradeLevel { get; set; }
    public override void DerseKatılım()
    {
        base.DerseKatılım();
        System.Console.WriteLine("Öğrenci Derse Katıldı");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Teacher teacher =new Teacher("Ahmet",29,"Bilgisayar");
        
        Student student= new Student("Aleyna",24,4);
       
    }
}
