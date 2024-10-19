using System.Reflection.Metadata.Ecma335;

namespace HomeWorks6;
public class Animal
{
    public Animal(string name, int age, string species)
    {
        Name = name;
        Age = age;
        Species = species;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public string Species { get; set; }
    
    public  virtual void MakeSound()
    {
        System.Console.WriteLine("Ses çıkardı");

    }



}
class Elephent : Animal
{
    public Elephent(string name, int age, string species) : base(name, age, species)
    {
    }
    public override void MakeSound()
    {
        System.Console.WriteLine($"{Name}boru sesi çıkardı");

    }


}
class Lion : Animal
{
    public Lion(string name, int age, string species) : base(name, age, species)
    {
    }
    public override void MakeSound()
    {
        System.Console.WriteLine($"{Name}Kükredi");

    }
}
class Gireffa : Animal
{
    public Gireffa(string name, int age, string species) : base(name, age, species)
    {
    }
    public override void MakeSound()
    {
        System.Console.WriteLine($"{Name}hortum sesi çıkardı");

    }

}







class Program
{
    static void Main(string[] args)
    {
        // Elephent elephent1 = new Elephent("Elif",24,"fil");
        // elephent1.MakeSound();
        // Lion lion1 = new Lion("ayşe",48,"aslan");
        // lion1.MakeSound();
        // Gireffa gireffa1= new("Zühre",51,"zürefa");
        // gireffa1.MakeSound();
    }
}


