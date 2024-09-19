using System;
using System.Diagnostics.Contracts;

namespace Project23_InheretenceSamples.CarManagmentSystem;

public abstract class Car
{
    public Car(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public string Brand { get; private set; }   
    public string Model  { get; set; }  
    public int Year { get; set; }   
    public void Start()
    {
        System.Console.WriteLine("araba basladı");
    }
    public void Stop()
    {
        System.Console.WriteLine("araba durdu");
    }
    public void DisPlayCarInfo()
    {
        System.Console.WriteLine($"Marka:{Brand}Model:{Model}Yıl{Year}");
    }
    public  abstract void GetSignal();
    



}

public class Veichle : Car
{
    public Veichle(string brand, string model, int year, byte countOfDoors = 0) : base(brand, model, year)
    {
        CountOfDoors = countOfDoors;
    }
    public byte CountOfDoors { get; set; }
    public void OpenTrunk()
    {
        System.Console.WriteLine("aracın üstü açıldı");

    }
    public void CloseTrunk()
    {
        System.Console.WriteLine("aracın üstü kapatıldı");

    }
    public override void DisPlayCarInfo()
    {

    }

}
public class MotorCycl : Car
{
    public MotorCycl(string brand, string model, int year) : base(brand, model, year)
    {
    }
    public int MyProperty { get; set; }
}
