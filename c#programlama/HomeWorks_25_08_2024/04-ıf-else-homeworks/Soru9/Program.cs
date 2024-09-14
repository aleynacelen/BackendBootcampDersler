namespace Soru9;

class Program
{
//     static void Main(string[] args)
//     {
//         Console.Write("Birinci sayıyı girin: ");
//         double sayi1 = ConvertToDouble(Console.ReadLine());

//         Console.Write("İkinci sayıyı girin: ");
//         double sayi2 = ConvertToDouble(Console.ReadLine());

//         Console.Write("Bir işlem girin (+, -, *, /): ");
//         char islem = ConvertToChar(Console.ReadLine());

//         // Hesaplama işlemini gerçekleştir ve sonucu ekrana yazdır
//         double? sonuc = Hesapla(sayi1, sayi2, islem);

//         Console.WriteLine(sonuc.HasValue ? $"Sonuç: {sonuc.Value}" : "Geçersiz işlem girdiniz.");
//     }

//     static double ConvertToDouble(string input)
//     {
//         double result;
//         while (!double.TryParse(input, out result))
//         {
//             Console.Write("Geçerli bir sayı girin: ");
//             input = Console.ReadLine();
//         }
//         return result;
//         static char ConvertToChar(string input)
//         {
//             char result;
//             while (!char.TryParse(input, out result) || (result != '+' && result != '-' && result != '*' && result != '/'))
//             {
//                 Console.Write("Geçerli bir işlem girin (+, -, *, /): ");
//                 input = Console.ReadLine();
//             }
//             return result;
//         }

//         static double? Hesapla(double a, double b, char islem)
//         {
//             return islem == '+' ? a + b :
//                    islem == '-' ? a - b :
//                    islem == '*' ? a * b :
//                    islem == '/' ? (b != 0 ? a / b : (Console.WriteLine("Bir sayıyı sıfıra bölemezsiniz."), (double?)null)) :
//                    (double?)null;
//         }
//     }

// }

