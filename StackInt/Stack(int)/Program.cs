using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_int_
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(5);
            Console.WriteLine(stack.isEmpty());
            Console.WriteLine(stack.isFull());
            stack.Push(5);
            stack.Push(10);
            stack.Push(15);
            stack.Push(3);
            stack.Push(7);
            Console.WriteLine(stack.isFull());
            stack.PrintArray();
            Console.WriteLine(stack.Count());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Count());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Count());
             
        }
    }
}
