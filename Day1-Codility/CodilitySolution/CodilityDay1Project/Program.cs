﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CodilityDay1Project
{
    class Program
    {
        void PrintInvertedTriangle(int n)
        {
            for (int i = n; i >0; i--)
            {
                for (int j = 0; j < (n-i); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (2*i-1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public int solution(int N)
        {
            bool startPoint = false;
            int len = 0, result = 0;
            Console.WriteLine(Convert.ToString(N,2));
            if (N == 0)
                return 0;
            int[] nums = new int[100];
            int count = nums.Where(n => n == 3).Count();
            if(count>=3)
            {
                
            }
            
           
            for (uint i = 1; i < N; i <<= 1)
            {
                Console.WriteLine(i);
                if ((i & N) != 0)
                {
                    if (startPoint)
                    {
                        if (len > result)
                        {
                            result = len;
                        }
                        len = 0;
                    }
                    startPoint = true;
                }
                else
                {
                    if (startPoint == true)
                        len++;
                }
            }

            return result;
        }
        void PrintAverageOfNumbersDivisibleBySeven(int[] arr)
        {
            List<int> n = new List<int>();
            n.Sort();
            n[n.Count - 1] = 100;
            string s = "Hello";
            
            int len = arr.Length;
            int sum = 0,count = 0;
            double result = 0;
            //for (int i = 0; i < len; i++)
            //{
            //    if(arr[i]%7 == 0)
            //    {
            //        sum += arr[i];
            //        count++;
            //    }
            //}
            foreach (int num in arr)
            {
                if (num % 7 == 0)
                {
                    sum += num;
                    count++;
                }
            }
            string str = "Hello";
            
            if(count!=0)//Handles if array is empty and no number is divisible by 7
                result = sum / count;
            Console.WriteLine("The result is "+result);
        }
        void ExplainSigleDimArar()
        {
            string[] names = { "Ramu", "Bimu", "Somu", "Pomu", "Komu" };
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }

        }
        void UnderstandingJaggedeArray()
        {
            int[][] array = new int[3][];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new int[i + 3];
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = i + j * (i * j);
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j]+" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            new Program().UnderstandingJaggedeArray();
            Console.ReadKey();
        }
    }
}
