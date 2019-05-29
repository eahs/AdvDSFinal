using System;
using System.Linq;
using System.Collections.Generic;
using ACMHelper;

namespace Problem03
{
    /*
     * Write a function that computes the list of the first 100 Fibonacci numbers. By definition, 
     * the first two numbers in the Fibonacci sequence are 0 and 1, and each subsequent number is 
     * the sum of the previous two. As an example, here are the first 10 Fibonnaci numbers: 
     * 0, 1, 1, 2, 3, 5, 8, 13, 21, and 34.
     */
    class Program
    {
        public static List<int> ComputeFibonacci ()
        {
            List<int> result = new List<int>();

            return result;
        }

        static void Main(string[] args)
        {
            List<int> fibs = ComputeFibonacci();

            Console.WriteLine("[{0}]", String.Join(", ", fibs));
        }
    }
}
