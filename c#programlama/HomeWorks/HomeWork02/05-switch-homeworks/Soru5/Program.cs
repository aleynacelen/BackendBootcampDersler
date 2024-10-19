namespace Soru5;

class Program
{
    static void Main(string[] args)
    {
        {
            Console.WriteLine("bir sayı giriniz (1-4 arasında)");
            string input = Console.ReadLine();
            int deger;
            bool deger1 = int.TryParse(input, out deger);
            if (deger1)
            {
                string mevsim;
                switch (deger)
                {
                    case 1:
                        mevsim = "kış";
                        break;
                    case 2:
                        mevsim = "sonbahar";
                        break;
                    case 3:
                        mevsim = "ilkbahar";
                        break;
                    case 4:
                        mevsim = "kış";
                        break;
                    default:
                        mevsim = "Sayı geçersiz";
                        break;


                }
                Console.WriteLine($"girdiğiniz sayı bu mevsim {mevsim}");
            else
                {
                    Console.WriteLine("GEÇERSİZ");

                }
            }


        }
    }
}
}
