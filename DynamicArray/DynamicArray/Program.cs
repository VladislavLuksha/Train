using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray array1 = new DynamicArray(20);
            DynamicArray array2 = new DynamicArray();
            array2.Add(5);
            array2.Add(10);
            array2.Add(20);
            array2[3] = 40;
            //Console.WriteLine(array2[1]);
            //Console.WriteLine(array2[2]);
            //Console.WriteLine(array2[3]);
            //Console.Write("IndexOf = ");
            //Console.WriteLine(array2.IndexOf(5));
            Console.WriteLine("Methods insert:");
            array2.PrintArray();
            array2.InsertElement(3, 2);
            Console.WriteLine("Result array:");
            array2.PrintArray();
        }
    }
}
