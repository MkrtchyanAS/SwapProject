using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapInt
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = 1;

            SwapInt(ref a, ref b);

            Console.WriteLine("a = {0}, b = {1}", a, b);

        }
        /// <summary>
        /// Take two variables and switch their values.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private static void SwapInt(ref int a, ref int b)
        {
            int c = a;
            a = b;
            b = c;
        }
    }
}
