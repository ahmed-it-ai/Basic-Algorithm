using System;
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
            while (n==0) {
                inter();
                int selcetedNumber = int.Parse(Console.ReadLine());
                //if (selcetedNumber == null) { break; }
                Console.Clear();
                selecting(selcetedNumber);
            }
        }
        public static void selecting (int selcetedNumber)
        {            
            switch (selcetedNumber)
            {
                case 1 :
                    TrianglesPatternsPrintV1();
                    break;
                case 2:
                    HollowTrianglePrint();
                    break;

                case 3:
                    PyramidShapePrint();
                    break;                    
                default:
                    Console.WriteLine("Invalid number :"+ selcetedNumber);
                    break;
            }

        }
        public static void inter()
        {
            Console.WriteLine();
            Console.WriteLine($"                select number of the Algorithm   ");
            Console.WriteLine("1- Print  Triangle Pattern ( Level 1 ) .");
            Console.WriteLine("2- Hollow Triangle Pattern ( Level 2 ) .");
            Console.WriteLine("3- Pyramid Shape   Pattern ( Level 3 ) .");            
            Console.Write("inter your number :");
        }
        /// <summary>
        /// selcet number 1 for TrianglesPatternsPrintV1
        /// </summary>
        public static void TrianglesPatternsPrintV1()
        {
            Console.Write("inter the size fo Triangle :");
             int size = int.Parse(Console.ReadLine());
            for (int x = 0; x < size ; x++)
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
            Console.Write("inter the size fo Triangle :");
            int size = int.Parse(Console.ReadLine());
            for (int x =0; x<size;x++)
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
            Console.Write("inter the size fo Triangle :");
            int size = int.Parse(Console.ReadLine());
            for (int x = 1; x<size+1;x++)
            {
                Console.WriteLine(" ");
                int space =size - x;
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

    }
}

