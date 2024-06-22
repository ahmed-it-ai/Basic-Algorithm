using System;

namespace week3_v3
{
    class Program
    {
        static void Main(string[] args)
        {            
            string[] Name = { "ahmed","admin","salma","eslam" };
            string[] phone = { "01100", "01111", "01122", "01133" };
            string ser = "salma";
            for (int x=0; x < Name.Length; x++)
            {
                if (Name[x]== ser)
                {
                    Console.WriteLine("found :" + phone[x]);
                    break;
                }
               
            }


        }
    }
}
