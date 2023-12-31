﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Euler17
{
    internal class Program
    {
        static readonly int[,] a = { { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0, 0 }, { 1, 2, 6, 10, 0, 0, 0 }, { 4, 5, 9, 0, 0, 0, 0 }, { 3, 7, 8, 40, 50, 60, 0 }, { 11, 12, 20, 30, 80, 90, 0}, { 15, 16, 70, 100, 0, 0, 0 }, { 13, 14, 18, 19, 0, 0, 0 }, { 17, 0, 0, 0, 0, 0, 0 } };
        static void Main(string[] args)
        {
            //Console.WriteLine(NumToCount(100));
            int sum = 0;
            for(int i = 1; i <= 1000; i++)
            {
                    //Console.WriteLine(i+" is "+NumToCount(i));
                sum = sum + NumToCount(i);
            }
            Console.WriteLine(sum);
        }
        public static int Search(int n)//gets a number and return in which line he is in the matrix "a"
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == n)
                        return i;
                }
            }
                
            return -100000;
        }
        public static int NumToCount(int x)//gets a number and return the amount of letters the number has``
        {
            if (x == 1000)
                return 11;
            int d1 = x / 100;
            int d2 = (x / 10) % 10;
            int d3 = x % 10;
            int and = 3;
            if (d2 + d3 == 0)
                and = 0;
            if (d2 * 10 + d3 < 21||d3==0)
            {
                if(d1>0)
                    return Search(d1)+Search(100)+and+ Search(d2 * 10 + d3);
                return Search(d2 * 10 + d3);
            }
            if (d1 > 0)
                return Search(d1) + Search(100)+and + Search(d2*10)+Search(d3);
            return Search(d2 * 10) + Search(d3);
        }
    }
}
