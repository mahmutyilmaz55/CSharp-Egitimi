using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Forecah Döngüsü

            //string[] cities = { "milano", "budapeşte", "roma", "samsun", "ankara", "istanbul", "berlin" };

            //foreach (var city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 45, 78, 985, 635, 75, 88, 32, 65 };

            //foreach (var number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 54651, 2565, 653, 456, 75, 61238, 738, 878, 9968 };
            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";

            //foreach (char s in word)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.Write("******** C# Eğitim Kampı Sınav Uygulaması ********");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            ////Sınıftaki öğrenci sayısını alma
            //Console.WriteLine("****************************************");
            //Console.Write("Sınıfınızda Kaç Öğrenci Var : ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("****************************************");

            ////Öğrenci isimlerini ve not ortalamasını saklayacak diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine();
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz : ");
            //    studentNames[i] = Console.ReadLine();

            //    Console.WriteLine();
            //    double totalExamResult = 0;
            //    //Her Öğrenci icin 3 sınav Notu Giris

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} isimli öğrencinin  {j + 1}. sınav notunu giriniz :  ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value;//Notları topluyoruz.
            //        Console.WriteLine();
            //    }
            //    studentExamAvg[i] = totalExamResult / 3;

            //    studentExamAvg[i] = totalExamResult / 3;
            //}
            
            ////Sınav Ortalamaları
            //for (int i = 0;i < studentCount;i++)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması : {studentExamAvg[i]}");
            //}

            ////Öğrencilerin Geçip-Kalma Durumları

            ////Öğrencilerin ortalaması ve gecip kalma durumları

            //for (int i = 0; i < studentCount; i++)
            //{
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten geçti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
            //    }
            //}
            #endregion
            Console.ReadLine();
        }
    }
}
