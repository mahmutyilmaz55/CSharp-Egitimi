using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.WriteLine("Merhaba Dunya!");
            //Console.WriteLine("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1 - Çorbalar");
            //Console.WriteLine("2 - Ana Yemekler");
            //Console.WriteLine("3 - Soğuk Başlangıçlar");
            //Console.WriteLine("4- - Salatalar");
            //Console.WriteLine("5 - Tatlılar");
            //Console.WriteLine("6 - İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region String Degiskenler
            ////string name;
            ////name = "C#";
            ////Console.WriteLine($"Name --> {name}");
            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "C#";
            //customerSurname = "Yazılım Dili";
            //customerPhone = "55555";
            //customerEmail = "deneme@deneme";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("***** Rezarvasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine($"Customer Name --> {customerName}");
            //Console.WriteLine($"Customer Surname --> {customerSurname}");
            //Console.WriteLine($"Customer Phone --> {customerPhone}");
            //Console.WriteLine($"Customer Email --> {customerEmail}");
            //Console.WriteLine($"Customer District --> {district}");
            //Console.WriteLine($"Customer City --> {city}");
            //Console.WriteLine();
            //Console.WriteLine("***** Rezarvasyon Kartı *****");

            #endregion

            #region Int Degiskenler
            int number = 24;
            Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("****** Restaurant Menu Fiyatları ******");
            Console.WriteLine();
            Console.WriteLine($"Hamburger Price --> {hamburgerPrice} ");
            Console.WriteLine($"Coke Price --> {cokePrice} TL");
            Console.WriteLine($"Water Price --> {waterPrice} TL");
            Console.WriteLine($"Fries Price --> {friesPrice} TL");
            Console.WriteLine($"Pizza Price --> {pizzaPrice} TL");
            Console.WriteLine($"Lemonade Price --> {lemonadePrice} TL");
            Console.WriteLine();
            Console.WriteLine("****** Restaurant Menu Fiyatları ******");
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalPrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalPrice = hamburgerCount * hamburgerPrice + cokeCount * cokePrice + waterCount * waterPrice + friesCount * friesPrice + pizzaCount * pizzaPrice + lemonadeCount * lemonadePrice;
            Console.WriteLine($"Total --> {totalPrice}");
            #endregion
            Console.ReadLine();
        }
    }
}