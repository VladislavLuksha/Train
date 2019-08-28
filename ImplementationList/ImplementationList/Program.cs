using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationList
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            list.Add(5);
            list.Add("abc");
            list.Add(7);
            list.Add(8);
            list.PrintList();
            list.Remove(5);
            list.Remove("abc");
            Console.WriteLine("Result list:");
            list.PrintList();
            Console.WriteLine(list.Contains(5));
            Console.WriteLine(list.Count);
            //list.Clear();
            //Console.WriteLine(list.Count);
            object[] array = new object[4];
            list.CopyTo(array, 1);
            foreach(object el in array)
            {
                Console.WriteLine(el);
            }
        }
    }
}
