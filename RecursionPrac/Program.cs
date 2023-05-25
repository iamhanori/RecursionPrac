using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibo = new Fibonacci();
            Console.WriteLine(fibo.Get(30));
            
            FibonacciAdv fiboAdv = new FibonacciAdv();
            Console.WriteLine(fiboAdv.Get(50000));
        }
    }
}
