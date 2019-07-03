using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class DynamicArray
    {
        int[] data;
        int capacity;
        int length;
        const int expandCoef=2;

        public DynamicArray()
        {
            capacity = 16;
            data = new int[capacity];
        }
        public DynamicArray(int size)
        {
            capacity = size;        
            data = new int[capacity];
        }

        public void Add(int number)
        {
            if (length == capacity)
            {
                int[] newData = new int[expandCoef * capacity];
                for (int i = 0; i <= length - 1; i++)
                {
                    newData[i] = data[i];
                }
                newData[length] = number;
                data = newData;
            }
            else
            {
                data[length] = number;
            }
            length++;
        }
    }
}
