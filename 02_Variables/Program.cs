using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Double Degiskenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine($"---- Elma Birim Fiyatı ---> {applePrice}" + " TL");
            //Console.WriteLine($"---- Portakal Birim Fiyatı ---> {orangePrice}" + " TL");
            //Console.WriteLine($"---- Çilek Birim Fiyatı ---> {strawberryPrice}" + " TL");
            //Console.WriteLine($"---- Patates Birim Fiyatı ---> {potatoPrice}" + " TL");
            //Console.WriteLine($"---- Domates Birim Fiyatı ---> {tomatoPrice}" + " TL");
            //Console.WriteLine();
            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double oranTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine($"Alınan Ürün Elma - Birim Fiyatı {applePrice} - Gramaj {appleGram} - Toplam Fiyat --> {appleTotalPrice}");
            //Console.WriteLine($"Alınan Ürün Portakal - Birim Fiyatı {orangePrice} - Gramaj {orangeGram} - Toplam Fiyat --> {oranTotalPrice}");
            //Console.WriteLine($"Alınan Ürün Portakal - Birim Fiyatı {strawberryPrice} - Gramaj {strawberryGram} - Toplam Fiyat --> {strawberryTotalPrice}");
            //Console.WriteLine($"Alınan Ürün Patates - Birim Fiyatı {potatoPrice} - Gramaj {potatoGram} - Toplam Fiyat --> {potatoTotalPrice}");
            //Console.WriteLine($"Alınan Ürün Domates - Birim Fiyatı {tomatoPrice} - Gramaj {tomatoGram} - Toplam Fiyat --> {tomatoTotalPrice}");

            //double shoppingTotalPrice = appleTotalPrice + oranTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine($"Toplam tutar --> {shoppingTotalPrice}");
            #endregion

            #region Char Degsikenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girisleri String Degiskenler

            //Console.WriteLine("******* C# Hava Yolları Yolcu Bilgisi *******");
            //Console.WriteLine();
            //string passengerName,passengerSurname,passengerDistrict,passengerCity,passengerIdentityNumber;

            //Console.Write("Yolcu Adı --> ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı --> ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yolcu İlce Bilgisi --> ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Yolcu İl Bilgisi --> ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik No --> ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();
            //Console.WriteLine("*********** Yolcu Bilgisi ***********");
            //Console.WriteLine();
            //Console.WriteLine($"Yolcu Adı --> {passengerName}");
            //Console.WriteLine($"Yolcu Soyadı --> {passengerSurname}");
            //Console.WriteLine($"Yolcu İlce --> {passengerDistrict}");
            //Console.WriteLine($"Yolcu İl --> {passengerCity}");
            //Console.WriteLine($"Yolcu TC Kimlik No --> {passengerIdentityNumber}");
            #endregion

            #region Klavyeden Tam sayi Girisleri ve Donusumler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 4000;
            //tvPrice = 1200;

            //int shoesCount,computerCount,chairCount,tvCount;

            //Console.Write("Alınan Ayakkabı Sayısı --> ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Alınan Bilgisayar Sayısı --> ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Alınan Sandalye Sayısı --> ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Alınan TV Sayısı --> ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            //Console.Write($"Toplam Ödenecek Tutar --> {totalPrice}");
            #endregion

            #region Klavyeden Ondalık Sayı İslemleri

            //double exam1, exam2, exam3, result;
            //Console.Write("1. Sınav Notu : ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.Write("2. Sınav Notu : ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("3. Sınav Notu : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) /  3;

            //Console.WriteLine();
            //Console.WriteLine($"Ortalama {result}");

            #endregion

            #region Klavyeden Karakter Girısleri

            char gender;
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Secilen Deger --> " + gender);
            #endregion
            Console.ReadLine();
        }
    }
}
