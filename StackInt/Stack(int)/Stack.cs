using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_int_
{
    class Stack
    {
        int[] array;
        int size;
        int top;

        public Stack(int size)
        {
            this.size = size;
            array = new int[size];
            top = 0;
        }

        public bool isEmpty()
        {
            return top == 0;
        }
        public bool isFull()
        {
            return top == size;
        }

        public int Count()
        {
            return top;
        }
        public void Push(int element)
        {
            array[top] = element;
            top++;
        }
        public int Peek()
        {
            return array[top-1];
        }
        public int Pop()
        {
            return array[--top];
        }
        public void PrintArray()
        {
            for(int i=top-1;i>=0;i--)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
