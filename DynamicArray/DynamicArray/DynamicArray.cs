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
            if(data.Length==capacity)
            {
                int[] data1 = new int[expandCoef * capacity];
                for (int i=0;i<=data.Length-1;i++)
                {
                    data1[i] = data[i];
                }
                data1[data.Length] = number;
                data = data1;
            }
            else
            {
                data[data.Length] = number;
            }
        }
    }
}
