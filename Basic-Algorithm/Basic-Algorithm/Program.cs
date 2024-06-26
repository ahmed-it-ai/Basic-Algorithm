﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Basic_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {           
            int n = 0;
            while (n == 0) {              
                inter();                
                int selcetedNumber = int.Parse(Console.ReadLine());                
                Console.Clear();                
                selecting(selcetedNumber);               
            }
        }
        public static void selecting(int selcetedNumber)
        {
            switch (selcetedNumber)
            {
                case 1:
                    TrianglesPatternsPrintV1();
                    break;
                case 2:
                    HollowTrianglePrint();
                    break;

                case 3:
                    PyramidShapePrint();
                    break;
                case 4:
                    ChristmasTreePrint();
                    break;

                case 5:
                    BubbleSorting();
                    break;

                case 6:
                   Console.WriteLine( $"Fibonacci Number is:    {Fibonacci(Size())}");
                    break;
                case 7:
                    SelectionSort();
                    break;
                case 8:
                    gitSumNumber();
                    break;                
                default:
                    Console.WriteLine("Invalid number :" + selcetedNumber);
                    break;
            }

        }
        public static void inter()
        {
            Console.WriteLine();
            Console.WriteLine($"                select number of the Algorithm   ");
            Console.WriteLine("1- Print  Triangle Pattern ( Task 1 ) .");
            Console.WriteLine("2- Hollow Triangle Pattern ( Task 2 ) .");
            Console.WriteLine("3- Pyramid Shape   Pattern ( Task 3 ) .");
            Console.WriteLine("4- Christmas Tree  Pattern ( Task 4 ) .");
            Console.WriteLine("5- Bubble Sorting  Number  ( Task 5 ) .");
            Console.WriteLine("6- Print Fibonacci Number  ( Task 6 ) .");
            Console.WriteLine("7- Selection Sort  Pattern ( Task 7 ) .");
            Console.WriteLine("7- git  Sum   of   Number  ( Task 8 ) .");
            //gitSumNumber()
            Console.Write("inter number Task :");
        }
        public static void prentTree(int n, int f)
        {
            for (int x = 0; x < n; x++)
            {
                Console.Write("____");
            }
            Console.Write($"n({f}) = F({n})");
            Console.WriteLine();
        }
        public static int Size()


        {
            Console.Write("inter the size :");
            return int.Parse(Console.ReadLine());
        }      
        public static void ArrayPrinter(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write($" {list[i]}");
            }
        } 
        public static int[] RandomNumber(int size)
        {
            int[] list = new int[size];
            var rand = new Random();
            for (int i = 0; i < size; i++)
            {
                list[i] = rand.Next(0, 20);
            }
            return list;
        }

        /// <summary>
        /// selcet number 1 for TrianglesPatternsPrintV1
        /// </summary>
        public static void TrianglesPatternsPrintV1()
        {
            int size = Size();
            for (int x = 0; x < size; x++)
            {
                Console.WriteLine();
                for (int i = 0; i < x; i++)
                {
                    Console.Write("* ");
                }
            }
        }
        public static void HollowTrianglePrint()
        {
            int size = Size();
            for (int x =0; x< size; x++)
            {
                Console.WriteLine();
                for (int i=1;i<x+1;i++)
                {
                    if (i==1 || i==x)
                    {
                        Console.Write("* ");
                    }
                    else if(x==size-1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    

                }
            }


        }
        public static void PyramidShapePrint()
        {
            int size = Size();
            for (int x = 1; x< size + 1;x++)
            {
                Console.WriteLine(" ");
                int space = size - x;
                int star = x * 2 - 1;
                while (space > 0)
                {
                    Console.Write("  ");
                    space--;
                }
                while (star > 0)
                {
                    Console.Write("* ");
                    star--;
                }
            }

        }
        public static void ChristmasTreePrint()
        {
            int size = Size();
           
            for (int i = 0; i < size; i++)  // To print the head of tree
            {
                for (int x = 0; x < size-i; x++) { Console.Write(" "); }
                for (int x = 0; x < i*2-1; x++) { Console.Write("*");}
                Console.WriteLine();
            }

            for (int i = size/2+1; i < size; i++)// To print the second part of the tree 
            {                
                for (int x = 0; x < size - i; x++) { Console.Write(" "); }
                for (int x = 0; x < i * 2 - 1; x++) { Console.Write("*"); }
                Console.WriteLine();
            }
            //To print the Root part of the tree
            for (int x = 0; x < size - 2; x++) { Console.Write(" "); }
            Console.WriteLine("|-|");
            for (int x = 0; x < size - 2; x++) { Console.Write(" "); }
            Console.WriteLine("|-|");
        }
        public static void BubbleSorting()
        {

            //to creat Array from Random Number and (n=size)
            int size = Size();
            int[] list = new int[size];
            list = RandomNumber(size);
            
            //to print list
            int larger, smaller;            
            Console.Write("Befor --> ((");
            ArrayPrinter(list);
            Console.Write("))");
            Console.WriteLine();

            //start sorting
            int CountLoop = 0;
            int CountShifting = 0;
            bool end = true;
            for (int i = 0;  i < list.Length; i++)
            {
                end = false;
                for (int x = 0; x < list.Length-1; x++)
                {
                    
                    smaller = list[x];
                    larger = list[x+1];
                    //to Shift
                    if (smaller>larger)
                    {
                        list[x] = larger;
                        list[x + 1] = smaller;
                        CountShifting += 1;
                        end = true;
                    }
                    CountLoop += 1;
                }
                if (end==false) { break;}
            }

            //to print list
            Console.Write("After --> ((");
            ArrayPrinter(list);
            Console.Write("))");
            Console.WriteLine($"\n Loop:{CountLoop} \n Shifting{CountShifting}");
        }        
        public static int Fibonacci (int n)
        {
            if (n<=1)
            {
                return n;
            }
            else
            {
                int r = Fibonacci(n - 1) + Fibonacci(n - 2);
                
                prentTree(n,r);
                return r;
            }
            
        }
        public static void SelectionSort()
        {
            int size = Size();
            int[] list = new int[size];
            var rand = new Random();
            for (int i = 0; i < size; i++)
            {
                list[i] = rand.Next(0, 10);
            }

            ArrayPrinter(list);

            int countLoop = 0;
            int countShift = 0;
            bool end = false;
            Console.WriteLine($"\n ");
            
            int smallerN = list[0];
           
            for (int i = 0; i < list.Length; i++)
            {
                for (int x = i+1; x < list.Length ; x++)
                {
                    if (list[i] > list[x])
                    {                        
                        smallerN = list[x];
                        list[x] = list[i];
                        list[i] = smallerN;
                        end = true;
                        countShift += 1;
                    }
                    countLoop += 1;
                }
                if (end = false) { break;}
            }
            ArrayPrinter(list);
            Console.WriteLine($"\n Loop:{countLoop} \n Shifting{countShift}");
        }
        public static int[] SelectionSort2(int[] list)
        {
            int countLoop = 0;
            int countShift = 0;
            bool end = false;            

            int smallerN = list[0];

            for (int i = 0; i < list.Length; i++)
            {
                for (int x = i + 1; x < list.Length; x++)
                {
                    if (list[i] > list[x])
                    {
                        smallerN = list[x];
                        list[x] = list[i];
                        list[i] = smallerN;
                        end = true;
                        countShift += 1;
                    }
                    countLoop += 1;
                }
                if (end == false) { break; }
            }
            return list;
        }
        public static void gitSumNumber()
        {
            int size = Size();
            Console.Write("your number is:");
            int n = int.Parse(Console.ReadLine());
            int[] list1 = new int[size];
            list1 = RandomNumber(size);
            int[] list = SelectionSort2(list1);                        
            Console.Write("((");
            ArrayPrinter(list);
            Console.Write("))");
            Console.WriteLine();
            int i = 0;
            int j = list.Length - 1;
            bool end = true;
            while (end)
            {
                if (list[i] + list[j] == n)
                {
                    break;
                } else if (list[i] + list[j] > n)
                {
                    j--;
                } else if (list[i] + list[j] < n)
                {
                    i++;
                }

                if (j <= 0 || i >= list.Length - 1){ end = false; }
            }
            if (end)
            {
                Console.WriteLine($"    (i={i}:j={j})\n    {n}={list[i]}+{list[j]}");
            }
            else
            {
                Console.WriteLine("Can Not fond !");
            }

            
        }

    }
}
