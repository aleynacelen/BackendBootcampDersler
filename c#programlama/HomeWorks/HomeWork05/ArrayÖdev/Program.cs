using System.Runtime.Serialization.Formatters;

namespace ArrayÖdev;

class Program
{
    static void Main(string[] args)


    {
        // #region Soru1

        // int[] dizi = new int[10];
        // Random random = new Random();
        // for (int i = 0; i < dizi.Length; i++)
        // {
        //     dizi[i] = random.Next(1, 100);
        // }

        // Console.WriteLine("Dizi elemanları:");
        // foreach (int sayi in dizi)
        // {
        //     Console.Write(sayi + " ");
        // }
        // Console.WriteLine();


        // Console.WriteLine("Özel elemanlar:");
        // for (int i = 1; i < dizi.Length - 1; i++)
        // {
        //     if (dizi[i] > dizi[i - 1] && dizi[i] > dizi[i + 1])
        //     {
        //         Console.Write(dizi[i] + " ");
        //     }
        // }
        // Console.WriteLine();

        // #endregion

        // #region Soru2
        // int[] tumSayilar = new int[10];
        // int[] ciftSayilar = new int[10]; 
        // int ciftSayiSayaci = 0;

        // Console.WriteLine("Lütfen 10 adet sayı giriniz:");
        // for (int i = 0; i < 10; i++)
        // {
        //     Console.Write("{0}. sayı: ", i + 1);
        //     tumSayilar[i] = Convert.ToInt32(Console.ReadLine());
        // }

        // for (int i = 0; i < 10; i++)
        // {
        //     if (tumSayilar[i] % 2 == 0)
        //     {
        //         ciftSayilar[ciftSayiSayaci] = tumSayilar[i];
        //         ciftSayiSayaci++;
        //     }
        // }

    
        // for (int i = 0; i < ciftSayiSayaci - 1; i++)
        // {
        //     for (int j = 0; j < ciftSayiSayaci - i - 1; j++)
        //     {
        //         if (ciftSayilar[j] > ciftSayilar[j + 1])
        //         {
        //             int temp = ciftSayilar[j];
        //             ciftSayilar[j] = ciftSayilar[j + 1];
        //             ciftSayilar[j + 1] = temp;

        

                    #endregion











                    //     #region Soru6

                    //     // Random rnd = new Random();
                    //     // int[] numbers = new int[100];
                    //     //  for (int i= 0;i< numbers.Length; i++)
                    //     //  {
                    //     //     numbers[i]= rnd.Next(1,100);


                    //     //  }

                    //     //  int min = numbers[0];
                    //     //  int max =numbers[0];

                    //     //  for (int i =1 ;i < numbers.Length; i++)

                    //     //  {
                    //     //      if(numbers[i]<min)
                    //     //  {
                    //     //     min = numbers[i];

                    //     //  } 
                    //     //    if (numbers[i]>max)
                    //     //    {
                    //     //     max = numbers[i];

                    //     //    }



                    //     //  }

                    //     //  Console.WriteLine("En küçük sayı " + min);
                    //     //  Console.WriteLine("En büyük sayı:"+ max);




                    //     #endregion

                    //     #region Soru7
                    //     // Random rnd =new Random();
                    //     // int[]numbers = new int[50];
                    //     // for (int i=0;i<numbers.Length;i++)
                    //     // {
                    //     //     numbers[i] = rnd.Next(1,1000);

                    //     // }
                    //     // int sumOfEvens=0;
                    //     // foreach (int number in numbers)
                    //     // {
                    //     //     if(number%2==0)
                    //     //     {
                    //     //         sumOfEvens += number;

                    //     //     }
                    //     // }

                    //     //     Console.WriteLine(sumOfEvens);
                    //     #endregion
                    //     #region Soru8

                    //     // Random rnd = new Random();
                    //     // int[] numbers= new int[10];
                    //     // for (int i = 0; i < numbers.Length; i++)
                    //     // {
                    //     //     numbers[i]= rnd.Next(1,100);

                    //     // }
                    //     // Console.WriteLine("Başlangıç :" + string.Join(", "), numbers);

                    //     // Console.WriteLine("Bir sayı girin:");
                    //     // int inputNumber;

                    //     // while (!int.TryParse(Console.ReadLine(),out inputNumber))
                    //     // {
                    //     //     Console.Write("Geçerli bir sayı giriniz");

                    //     // }

                    //     // bool isFound = false;
                    //     // foreach (int number in numbers)
                    //     // {

                    //     // }

                    //     #endregion

                    //     #region Soru9
                    //     // int[] numbers = { -5,8,3,-1,6,-7,2,0};
                    //     // Console.WriteLine( "Başlangiç dizisi "+string.Join(",",numbers));
                    //     // var positiveNumbers = numbers.Where(x=>x>0).ToList();

                    //     // positiveNumbers.Reverse();
                    //     // int[] result= new int[numbers.Length];
                    //     // int positiveIndex = 0;

                    //     // for (int i =0;i<numbers.Length; i++)
                    //     // {
                    //     //     if(numbers[i]>0)
                    //     //     {
                    //     //         result[i]= positiveNumbers[positiveIndex];
                    //     //         positiveIndex++;


                    //     //     }
                    //     //     else
                    //     //     {
                    //     //         result[i]= numbers[i];

                    //     //     }
                    //     //     Console.WriteLine(string.Join(",",result));

                    //     // }




                    //     #endregion
                    //     #region Soru1 0
                    //     // int[] numbers ={0,1,2,3,4,5,6,7,8,9,10};
                    //     // Console.Write("Başlangıç dizisi" +string.Join(",",numbers));
                    //     // int[] neWnumbers = new int[numbers.Length];
                    //     //  for (int i = 0; i < numbers.Length; i++)
                    //     //  {
                    //     //     neWnumbers[i]=numbers[numbers.Length -1 -i];
                    //     //  }
                    //     //  Console.WriteLine("Ters Hali:" + string.Join(",",neWnumbers));



                    //     #endregion
                    //     #region Soru11
                    //     // Console.Write("Bir cümle giriniz");
                    //     // string input = Console.ReadLine();
                    //     // string[] words =input.Split(' ');
                    //     // int index = words.Length -1 ;
                    //     // Console.WriteLine("Kelimeler tersten:");
                    //     // while(index>=0)
                    //     // {
                    //     //     Console.WriteLine(words[index]);
                    //     //     index--;

                    //     // }

                    //     #endregion

                    //     #region Soru 12


                    //     #endregion

                    //     #region Soru 13
                    //     // int[] numbers = {5,12,7,9,14,8,4,11,6,3};
                    //     // int sumOfOdds =0;
                    //     // foreach (int number in numbers)
                    //     // {
                    //     //     if (number%2 !=0)
                    //     //     {
                    //     //         sumOfOdds += number;

                    //     //     }
                    //     // }

                    //     // Console.WriteLine("TEK SAYILARIN TOPLAMI :"+ sumOfOdds);
                    //     // İf (sumOfOdds%2==0);
                    //     // {
                    //     //     System.Console.WriteLine("Toplam Çift Sayı");
                    //     // }
                    //     // else
                    //     // {
                    //     //     System.Console.WriteLine("Toplam tek satı");
                    //     // }


                    //     #endregion

                    //     #region Soru 14
                    //     int[] numbers = new int[20];
                    //     Random random = new Random();
                    //     for (int i = 0; i < numbers.Length; i++)
                    //     {
                    //         numbers[i] = random.Next(1, 101); 
                    //     }
                    //     System.Console.WriteLine("Dizi: " + string.Join(", ", numbers));
                    //     int ucebolum = 0;
                    //     foreach (int number in numbers)
                    //     {
                    //         if (number % 3 == 0)
                    //         {
                    //             ucebolum += number;
                    //         }

                    //         for (int i = 0; i < sumStr.Length; i++)
                    //         {
                    //             Console.Write(sumStr[i]);

                    //             if ((i + 1) % 5 == 0 && i != sumStr.Length - 1)
                    //             {
                    //                 Console.Write(' ');
                    //             } //Chatgpt
                    //         }

                    //         Console.WriteLine(); 
                    //     }



                    //     #endregion

                    //     #region Soru15
                    //   int[] numbers = {2,3,5,8,11,6,7};
                    //   //OrderBy; belirli kriterlere göre elemanları sıyalan method.
                    //   int[] oddnumbers=numbers.Where(number=> number%2!0).OrderBy(numbers=>number).ToArray();
                    //   int oddnumbersIndex=0;
                    //   for (int i = 0; i < numbers.Length; i++)
                    //   {
                    //     numbers[i]= oddnumbers.[oddnumbersIndex]; //iki dizi arasıbda eleman kopyalama işlemi
                    //     oddnumbersIndex++;
                    //   }

                    //   Console.WriteLine(string.Join(",",numbers));
                    //   int input;
                    //   int sayaç=0;
                    //   int[] new int[10];
                    //   int top=0;

                    //   do
                    //   {
                    //     System.Console.WriteLine("Bir sayı giriniz ==>"input=int.Parse(Console.ReadLine());

                    //     if(input!=0)
                    //     {
                    //         dizi[sayaç]= input;
                    //         top+= input;
                    //         sayaç++

                    //     }

                    //   } while (input!=0 && sayaç <DivideByZeroException.Length);
                    //   Array.Resize(ref dizi,DivideByZeroException.Lenght);
                    //   foreach (var item in dizi)
                    //   {
                    //     System.Console.WriteLine(item);
                    //   }
                    //   if (sayaç>0)
                    //   {
                    //     double ort =(double)top/sayaç;
                    //     System.Console.WriteLine($"sayılarımızın ort={ort}");

                    //   }
                    //   int sayi;
                    //   List<int> sayilar =new List<int>();
                    //   do
                    //   {
                    //     Console.Write("Bir sayı giriniz =>" input =int.Parse(Console.ReadLine()));
                    //     if(input!=0)
                    //     {
                    //         dizi[sayaç]=input;
                    //         top+=input;
                    //         sayaç++

                    //     }

                    //   } while (input != 0&& sayaç < dizi.Lenght);
                    //   Array.Resize(ref dizi, dizi.Lenght);
                    //   foreach (var item in dizi)
                    //   {
                    //     System.Console.WriteLine(item);
                    //   }
                    //   if(sayaç>0)
                    //   {
                    //     double ort = (double)top/sayaç;
                    //     System.Console.WriteLine($"sayılarımızın ortalamaası"={ort});
                    //     sayi =Convert.ToInt32(Console.ReadLine());
                    //     if (sayi!=0)
                    //     {
                    //         sayilar.Add(sayi);

                    //     }
                    //     while (sayi!=0)
                    //     {
                    //         *************
                    //     }

                    //   }



                    // #endregion

                    //         #region Soru 16

                    //         int[] sayilar = new int[100]; 
                    //         int sayac = 0, sayi;
                    //         double toplam = 0;

                    //         do
                    //         {
                    //             Console.Write("Bir sayı giriniz (Çıkmak için 0): ");
                    //             sayi = Convert.ToInt32(Console.ReadLine());

                    //             if (sayi != 0)
                    //             {
                    //                 sayilar[sayac] = sayi;
                    //                 toplam += sayi;
                    //                 sayac++;
                    //             }
                    //         } while (sayi != 0);


                    //         double ortalama = toplam / sayac;

                    //         Console.WriteLine("Girilen sayılar:");
                    //         for (int i = 0; i < sayac; i++)
                    //         {
                    //             Console.Write(sayilar[i] + " ");
                    //         }

                    //         Console.WriteLine("\nSayıların ortalaması: " + ortalama);
                    //     }


                    //     #endregion
                    //     #region Soru17
                    //     int[] sayilar = { 4,9,2, 0,8,3 }; 
                    //     int enBuyuk1 = int.MinValue;
                    //     int enBuyuk2 = int.MinValue;

                    //             for (int i = 0; i<sayilar.Length; i++)
                    //             {

                    //                 if (sayilar[i] > enBuyuk1)
                    //                 {
                    //                     enBuyuk2 = enBuyuk1;
                    //                     enBuyuk1 = sayilar[i]; 

                    //                 else if (sayilar[i] > enBuyuk2 && sayilar[i] != enBuyuk1)
                    //                 {
                    //                     enBuyuk2 = sayilar[i];
                    //                 }
                    //             }

                    //             Console.WriteLine("En büyük sayı: " + enBuyuk1);
                    // Console.WriteLine("İkinci en büyük sayı: " + enBuyuk2);
                    //     #endregion


                }

