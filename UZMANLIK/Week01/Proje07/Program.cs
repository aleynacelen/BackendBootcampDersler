
//SENKRON
//String içinde \r ne işe yarar araştırınız
// System.Console.WriteLine("1.İşlem(5sn)");
// for (int i = 1; i <=5; i++)
// {
//     System.Console.WriteLine($"\r[1. işlem] Geçen süre: {i} saniye ");
//     Thread.Sleep(1000); // 1 sn beklemesini sağladı
// }
// System.Console.WriteLine("BİRİNCİ İŞLEM SONA ERDİ(5 SANİYE)");

// System.Console.WriteLine("2.İşlem(10sn)");

// for (int i = 1; i <= 10; i++)
// {
//     System.Console.WriteLine($"\r[2. işlem] Geçen süre: {i} saniye ");
//     Thread.Sleep(1000); // 1 sn beklemesini sağladı
// }

//ASEKRON

string task1Status = "5 saniyelik işlem bekleniyor..";
string task2Status ="10 saniyelik işlem bekleniyor..";


object consoleLock = new Object();

Thread thread1 = new Thread(()=>
{
    for (int i = 1; i <=5; i++)
    {
       lock (consoleLock)
       {
            task1Status = $"5snlik işlem için geçen süre {i} saniye";
            Console.Clear();
            System.Console.WriteLine($"{task1Status}\n{task2Status}");
        }
        Thread.Sleep(1000);

    }
    lock (consoleLock)
    {
        task1Status = "5 snlik işlem tamamlandı";
        Console.Clear();
        System.Console.WriteLine($"{task1Status}\n{task2Status}");
    }

   

});
Thread thread2 = new Thread(() =>
{
    for (int i = 1; i <= 10; i++)
    {

        lock (consoleLock)
        {
            task2Status = $"10snlik işlem için geçen süre {i} saniye";
            Console.Clear();
            System.Console.WriteLine($"{task1Status}\n{task2Status}");
        }
        
        Thread.Sleep(1000);

    }
    lock (consoleLock)
    {
        task2Status = "10 snlik işlem tamamlandı";
        Console.Clear();
        System.Console.WriteLine($"{task1Status}\n{task2Status}");
    }
   

});
thread1.Start(); 
thread2.Start();


