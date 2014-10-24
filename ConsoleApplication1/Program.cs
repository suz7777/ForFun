using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ConsoleApplication1;


namespace ConsoleApplication1
{


    class Program
    {
        
        static void Main(string[] args)
        {
            int start = 1;
            int end = 50;
            for (int i = start; i < end; i++)
                Console.WriteLine(ConsoleApplication1.suznumbers.fizzbuzz(i));
            Console.ReadLine();
        }
    }
}

