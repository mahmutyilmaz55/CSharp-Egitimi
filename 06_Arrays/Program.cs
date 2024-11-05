using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";


            //int[] numbers = new int[10];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //numbers[4] = 5;
            //numbers[5] = 6;
            //numbers[6] = 7;
            //numbers[7] = 8;

            //Console.WriteLine(numbers[8]);

            //string[] cities = { "Ankara", "Bursa", "İzmir" };

            //Console.WriteLine(cities[0]);


            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Yeşil", "Mavi", "Mor", "Kırmızı","Turuncu"};

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', 'd' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "a", "b", "c", "d", "e", "f", "g", "h" };
            //Console.WriteLine(persons.Length);
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Array.Sort(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 1, 2, 56, 45, 78, 21, 69, 67, 48 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Methodları

            //string[] customers = {"a","b","c","d","e","f","g","h"};
            //int index = Array.IndexOf(customers, "a");
            //Console.WriteLine(index);

            //int[] numbers = { 41, 52, 93, 14, 75, 66, 47, 58, 90 };
            //Console.WriteLine($"Dizinin En Büyük Elemanı --> {numbers.Max()} --- Dizinin En KüCÜK Elemanı --> {numbers.Min()}");


            #endregion

            #region Kullanıcında Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehrini Giriniz : ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("------------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 145, 682, 543, 194, 655, 436, 787, 870, 905,100,118,129};
            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);               
            //    }
            //}

            //Console.WriteLine("----------------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for(int i = 0;i < numbers.Length; i++)
            //{
            //    if(i % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            #endregion
            Console.ReadLine();
        }
    }
}
