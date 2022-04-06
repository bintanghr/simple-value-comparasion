using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numbers number = new Numbers();

            Console.WriteLine("Find Minimum #1 = {0}", number.FindMinimum(6,7));
            Console.WriteLine("Find Minimum #2 = {0}", number.FindMinimum(3, 7, 5));
            Console.WriteLine();
            Console.WriteLine("Find Maximum #1 = {0}", number.FindMaximum(4, 6));
            Console.WriteLine("Find Maximum #2 = {0}", number.FindMaximum(8, 1, 7));

            Console.ReadKey();
        }
    }
}
