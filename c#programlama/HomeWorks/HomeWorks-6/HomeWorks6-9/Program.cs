namespace HomeWorks6_9;



public class Account
{
    public Account(int accountno, decimal balance)
    {
        Accountno = accountno;
        Balance = balance;
    }

    public int Accountno { get; set; }
    public decimal Balance { get; set; }
    public virtual void BilgiYaz()
    {
        System.Console.WriteLine($"Hesap{Accountno}\nHesap Bakiyesi{Balance}");

    }



}
class SavingAc : Account
{
    public SavingAc(int accountno, decimal balance) : base(accountno, balance)
    {
    }
    public override void BilgiYaz()
    {
        base.BilgiYaz();
    }
}
class ChekingAccount : Account
{
    public ChekingAccount(int accountno, decimal balance) : base(accountno, balance)
    {
    }
    public override void BilgiYaz()
    {
        base.BilgiYaz();

    }
    public void WriteChek()
    {
        System.Console.WriteLine("Çek yaz");
    }
}


class Program
{
    static void Main(string[] args)
    {
    //     SavingAc savingAc = new SavingAc(19007,1907);
    //    ChekingAccount chekingAccount = new ChekingAccount(1907,1907);
    //    chekingAccount.WriteChek();
       
    }
}
