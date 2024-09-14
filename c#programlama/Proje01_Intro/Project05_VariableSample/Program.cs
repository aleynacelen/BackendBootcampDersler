namespace Project05_VariableSample;

class Program
{
    static void Main(string[] args)
    {
        #region  Yaş Hesaplama
        // //Kullanıcıdan doğum yılunı alıp yaşını hazırlayacak ve bunu ekrana yazdıracak kodu hazırlıyoruz.
        // Console.Write("Doğum yılınızı giriniz: ");
        // string input = Console.ReadLine(); //"1975" metinsel bir değer olucak

        // int birthYear = int.Parse(input); //1975
        // int calculatedAge = DateTime.Now.Year - birthYear;
        // string message = "Yaşınız:" + calculatedAge;
        // Console.WriteLine(message);


        #endregion

        #region Ürün Fiyatı Hesaplama
        //bir ürünün fiyatı girildiğinde onun kdv dahil fiyatını hesaplayıp hem ham hem de Kdv dahil fiyatını ekrana yazdırınız
        // Console.Write("Ürün fiyatını giriniz: ");
        // decimal productPrice = decimal.Parse(Console.ReadLine());

        // double vatRate = 0.18;
        // double vat = (double)productPrice * vatRate ;
        // decimal totalProductPrice = productPrice + (decimal)vat ;


        // string resultMessage =$@"Ürün Fiyatı : {productPrice} 
        // KDV :{vat}
        // KDV Dahil Fiyat : {totalProductPrice}";

        // Console.WriteLine(resultMessage);
        // string resultMessage = $"ürün fiyatı  : {productPrice}"
        // \nKDV  :{vat}nKdv Dahil Fiyat :
        // {totalProductPrice};
        // Console.WriteLine


        #endregion


        #region Sıcaklık Dönüştürme

        //Kulanıcıdan c cinsinden alının sıcaklık değerini f cinsine cevirip ekrana her ikimide alt alta yazdıdan kodu hazırlıyoruz//C × 1.8 + 32
        // Console.WriteLine("Sıcaklık giriniz :");
        // string input = Console.ReadLine();
        // int cSıcaklık = int.Parse(input);
        // int fsıcaklık = cSıcaklık * 9/5 + 32;
        // string message = "sıcaklık" + fsıcaklık;
        
        // Console.WriteLine($@ Fahrenayt : {message}
        // Celcıus :{cSıcaklık});

        // Console.Write("Celcius sıcaklık değerini giriniz");
        // double celcius = double.Parse(Console.ReadLine());
        // double fahrenheit = (celcius * 1.8) + 32 ;
        // string resultMessage =$"Celcius: {Convert.ToInt32(celcius)}\n Fahrenheist: {Convert.ToInt32(fahrenheit)}";
        // Console.WriteLine();
        // Console.WriteLine("Sonuç:");
        // Console.WriteLine(resultMessage);



        

            
        #endregion

        #region Ağırlık Dönüştürm

        // kg cinsinden olanı grama cevir sonuç ekranında hem kg hemde gram gözüksün
        // Console.WriteLine("kg cinsini giriniz");
        // double kg =double.Parse(Console.ReadLine());
        // double gram = kg*1000;
        // string resulMessage = $"Kg : {kg} \n Gram : {gram}";
        // Console.WriteLine("Sonuç:");
        // Console.WriteLine(resulMessage);


            
        #endregion
        
        #region 
            
        #endregion





    }
}
