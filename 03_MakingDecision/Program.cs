using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region If else
            //Console.Write("Lütfen Şifreyi Giriniz --> ");
            //String password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz --> ");
            //capital = Console.ReadLine();
            //Console.Write("Ülke Giriniz -->");
            //country = Console.ReadLine();
            //if (capital=="Ankara" && country=="Türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı");                
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi");
            //}

            //int number;
            //Console.Write("Sayi Giriniz --> ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Secilen Sayi 5");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Giriş");
            //}
            //int exam1, exam2, exam3, average;
            //string result = "Hata!";
            //Console.Write("Sınav 1 --> ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2 --> ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3 --> ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine($"Sınav Ortalama --> {average}");

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuc Vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuc Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "İyi";
            //}
            //if (average > 84 & average <= 100)
            //{
            //    result = "Pekiyi";
            //}
            //Console.WriteLine(result);


            //string city;
            //Console.WriteLine("Lütfen Sehir Girisi Yapiniz --> ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon" )
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}
            //Console.WriteLine("Lütfen kullanıcı adınızı giriniz : ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Kullanıcı Kabul Edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Giriş Başaralı");
            //}
            #endregion

            #region Mod Islemleri

            //int number;
            //number = 26;
            //int result = number;
            //Console.WriteLine(result);

            //Console.WriteLine("1. Sayıyı Giriniz : ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2. Sayıyı Giriniz : ");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;
            //Console.WriteLine($"Kalan --> {result}");

            //Console.WriteLine("Sayi Giriniz : ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayi Ciftir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayi Tektir");
            //}
            #endregion

            #region Örnek Uygulama
            //Console.WriteLine("********** C# Eğitim Kampı **********");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");
            //Console.WriteLine("1 - Ana Yemekler");
            //Console.WriteLine("2 - Çorblar");
            //Console.WriteLine("3 - Pizzalar");
            //Console.WriteLine("4 - İçecekler");
            //Console.WriteLine("5 - Tatlılar");
            //Console.WriteLine("-------------------------------------");
            //string menuItem;
            //Console.Write("Menu Seciniz : ");
            //menuItem = Console.ReadLine();
            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("*********** Ana Yemekler ***********");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Tavuk");
            //    Console.WriteLine("2 - Makarna");
            //    Console.WriteLine("3 - Patlıcan Musakka");
            //    Console.WriteLine("4- Pilav");
            //    Console.WriteLine("5 - Balık");
            //    Console.WriteLine("*********** Ana Yemekler ***********");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("*********** Çorbalar ***********");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Mercimek");
            //    Console.WriteLine("2 - Ezogelin");
            //    Console.WriteLine("*********** Çorbalar ***********");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("*********** Pizzalar ***********");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Akdeniz Pizza");
            //    Console.WriteLine("2 - Margaritha Pizza");
            //    Console.WriteLine("3 - Karışık Pizza");
            //    Console.WriteLine("*********** Çorbalar ***********");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("*********** İçecekeler ***********");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Kola");
            //    Console.WriteLine("2 - Ayran");
            //    Console.WriteLine("3 - Su");
            //    Console.WriteLine("*********** İçecekeler ***********");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("*********** Tatlılar ***********");
            //    Console.WriteLine();
            //    Console.WriteLine("1 - Triliçe");
            //    Console.WriteLine("2 - Kazan Dibi");
            //    Console.WriteLine("3 - Sütlaç");
            //    Console.WriteLine("*********** Tatlılar ***********");
            //    Console.WriteLine();
            //}
            #endregion

            #region Switch Case

            //Console.WriteLine("Lütfen Ay Girişi Yapınız : ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default:Console.WriteLine("Yanlış Giriş");break;
            //}

            #endregion

            #region Swicth Hesap Makinesi
            int number1, number2, result;
            char sembol;

            Console.WriteLine("1. Sayiyi Giriniz : ");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. Sayiyi Giriniz : ");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("İşlemi Giriniz : ");
            sembol = char.Parse(Console.ReadLine());
            switch (sembol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine($"Toplam --> {result}");
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine($"Cikarma --> {result}");
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine($"Carpma --> {result}");
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine($"Bolme --> {result}");
                    break;

            }
            #endregion
            Console.ReadLine();
        }
    }
}
