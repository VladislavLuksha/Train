using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeArray =7;
            QuickSorting quick = new QuickSorting(sizeArray);
            quick.InitializationArray();
            quick.ArrayPrinting();
            quick.QuickArraySorting(0, sizeArray - 1);
            Console.WriteLine("ArraySorting:");
            quick.ArrayPrinting();
        }
    }
}
