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
            while (true) {
                inter();
                int selcetedNumber = int.Parse(Console.ReadLine());
                Console.Clear();
                selecting(selcetedNumber);
            }
        }
        public static void selecting (int selcetedNumber)
        {            
            switch (selcetedNumber)
            {
                case 1 :
                   PrintTrianglesPatternsV1();
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
            Console.WriteLine("1- Print Triangles Patterns ( Level 1 ) .");
            Console.Write("inter your number :");
        }
        public static void PrintTrianglesPatternsV1()
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

    }
}

