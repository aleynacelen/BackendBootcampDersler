namespace HomeWorks6_3;



 public class Employee
{
    public Employee(string name, int ıd, decimal salary)
    {
        Name = name;
        Id = ıd;
        Salary = salary;
    }

    public string Name { get; set; }
    public int Id { get; set; }
    public decimal Salary { get; set; }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Isım: {Name}\nNumara: {Id}\nMaas: {Salary}");
    }

}
class Manager : Employee
{
    public Manager(string name, int ıd, decimal salary, int v) : base(name, ıd, salary)
    {
    }
    public int NumberOfTeams { get; set; }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        System.Console.WriteLine($"Takım sayısı {NumberOfTeams}");
    }
}
class Developer : Employee
{
    public Developer(string name, int ıd, decimal salary, string programmingLanguage) : base(name, ıd, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }
    public string ProgrammingLanguage { get; set; }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        System.Console.WriteLine($"Pogramlama dili{ProgrammingLanguage}");
    }
}

class Intern : Employee
{
    public Intern(string name, int ıd, decimal salary) : base(name, ıd, salary)
    {
    }
}




class Program
{
    static void Main(string[] args)
    {
        // Manager manager1 = new Manager("Aleyna",1200,100000,4);
        // manager1.DisplayInfo();
        // Developer developer1 = new Developer("hande",12001,500000,"c#");
        // developer1.DisplayInfo();
        // Intern ıntern1= new Intern("Hale",12002,25000);
      
    }
}
