using System;
using System.Linq;
using System.Collections.Generic;
using ACMHelper;

namespace Problem01
{
    /*
     *  Write three functions that compute the sum of the numbers in a given list using a for-loop, 
     *  a while-loop, and recursion.
     * 
     */
    class Program
    {
        public static int ForLoopSum (List<int> nums)
        {
            // FIXME

            return 0;
        }

        public static int WhileLoopSum(List<int> nums)
        {
            // FIXME

            return 0;
        }

        public static int RecursiveSum(List<int> nums)
        {
            // FIXME

            return 0;
        }


        static void Main(string[] args)
        {
            List<int> list = "1 2 3 4 5 6 7 8 9 10".ToIntegerList();

            Console.WriteLine("For loop sum = " + ForLoopSum(list));
            Console.WriteLine("While loop sum = " + WhileLoopSum(list));
            Console.WriteLine("Recursive sum = " + RecursiveSum(list));
        }
    }
}
