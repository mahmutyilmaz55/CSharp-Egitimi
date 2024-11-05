﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopWithStars
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Alt alta 10 tane yıldız olusturma

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion

            #region Yan yana 10 tane yıldız olusturma

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}
            #endregion

            #region Alt alta 10 tan yıldız oluşturma her satırda 10 tane yıldız olacak

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}

            #endregion

            #region Dik Ucgen Olusturma

            //for (int i = 0; i <= 5; i++)
            //{
            //    for(int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ters Dik Ucgen Olusturma

            //for (int i = 5; i > 1; i--)
            //{
            //    for (int j = 1; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Alt alta 10 tane yıldız olusturma

            //for (int i = 0; i <= 5; i++)
            //{
            //    for (int j= 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int k = 4; k >= 1; k--)
            //{
            //    for(int m= 1;m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Baklava Dilimi
            //üst kısım
            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n-1; j > 0; j--)
            //    {
            //        Console.Write(" ");  
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            ////alt kısım
            //for (int i = n-1; i >=1 ; i--)
            //{
            //    for(int j = n -1;j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for(int k = 1;k <= 2 * i - 1;k++)
            //    {

            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Piramit

            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n-i; j>0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i -1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Ters Piramit
            int n = 5;
            for (int i = n; i >= 1; i--)
            {
                //Bosluklar
                for (int j = n-i;j>= 0; j--)
                {

                    Console.Write(" ");
                }
                //Yıldızlar
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion
            Console.ReadLine();
        }
    }
}
