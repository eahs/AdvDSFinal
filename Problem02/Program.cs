using System;
using System.Linq;
using System.Collections.Generic;
using ACMHelper;

namespace Problem02
{
    /*
     * Write a function that combines two lists by alternatingly taking elements. 
     * For example: given the two lists [4, 5, 6] and [1, 2, 3], the function should 
     * return [4, 1, 5, 2, 6, 3].
     */
    class Program
    {
        public static List<int> Merge (List<int> a, List<int> b)
        {
            return null;  // FIXME
        }

        static void Main(string[] args)
        {
            List<int> a = "4 5 6".ToIntegerList();
            List<int> b = "1 2 3".ToIntegerList();

            String merged = String.Join(", ", Merge(a, b));

            Console.WriteLine("[{0}]", merged);
        }
    }
}
