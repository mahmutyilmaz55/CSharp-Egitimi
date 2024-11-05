using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methodlar
            
            //void CustomerList()
            //{
            //    Console.WriteLine("AA");
            //    Console.WriteLine("BB");
            //    Console.WriteLine("CC");
            //}
            //CustomerList();


            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli methodlar

            //void writeMethod(string customerName)
            //{
            //    Console.WriteLine($"Ad - Soyad  --> {customerName}");
            //}
            //writeMethod("Ali Veli");

            void customerCard(string name,string surname)
            {
                Console.WriteLine($"Müster --> {name} --- {surname}");
            }
            customerCard("XX","XX");
            customerCard("AA", "BB");
            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli methodlar

            //void Sum(int number1 , int number2)
            //{
            //    int result = number1 + number2;
            //    Console.WriteLine($"Toplam --> {result}");
            //}
            //Sum(98,46);
            #endregion

            #region Geriye Değer Döndüren Methodlar

            //string CustomerName()
            //{
            //    return "Customer Name";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "C#";
            //    string surname = "Development";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());


            #endregion

            #region Geriye Değer Döndüren Parametreli Methodlar

            string CountryCard(string countryName,string capital,string flagColor)
            {
                string cardInfo ="Ülke" + " " + countryName + " " + "Başkent" + " " + capital + " " + "Bayrak" + " "  + flagColor;
                return cardInfo;
            }
            string x, y, z;

            Console.Write("Ülke Adını Giriniz : ");
            x = Console.ReadLine();
            Console.Write("Başkent Adını Giriniz : ");
            y = Console.ReadLine();
            Console.Write("Bayrak Rengini Giriniz : ");
            z = Console.ReadLine();

            Console.WriteLine();
            Console.Write(CountryCard(x, y, z));
            #endregion

            #region Geriye Deger Donduren Int Parametreli Metotlar

            //int Sum(int number1,int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(158, 546));
            #endregion

            #region Örnek Uygulama
            string ExampleResult(string student, int exam1,int exam2,int exam3)
            {
                int result = (exam1 + exam2 + exam3);
                if (result >= 50)
                {
                    return "Öğrenci sınavı geçti";    
                }
                else
                {
                    return "Öğrenci başarısız oldu.";
                }
            }

            Console.WriteLine(ExampleResult("A",55,66,44));
            #endregion
            Console.ReadLine();
        }
    }
}
