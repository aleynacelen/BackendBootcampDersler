using System;

namespace ConsoleApp3;

public class Cat:Animal
{
    public Cat(string name, int age, string renk) : base(name, age)
    {
        Renk = renk;
    }

    public string Renk { get; set; }

}
