using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Collections.Specialized;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCalc myCalc = new MyCalc();
            int a = myCalc.Sum(1,4);
            Console.WriteLine(a);
        }
    }
}
