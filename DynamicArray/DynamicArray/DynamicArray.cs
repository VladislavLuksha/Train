using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class DynamicArray:IEnumerator
    {
        int[] data;
        int capacity;
        int length;

        const int expandCoef=2;
        const int capacityArray = 4;

        private int foreachIndex;
        public object Current => data[foreachIndex];

        public DynamicArray()
        {
            capacity = capacityArray;
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
        public int this[int index]
        {
            get
            {
                if (index>length || index<0)
                {
                    throw new IndexOutOfRangeException();
                }
                return data[index];
            }
            set
            {
                if (index > length || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                data[index] = value;
            }
        }

        public void ArrayPrinting()
        {
            foreach(int it in data)
            {
                Console.WriteLine(it);
            }
        }

        public int IndexOf(int number)
        {
            for (int index=0;index<=length;index++)
            {
                int tempNumber=data[index];
                if (tempNumber == number)
                {
                    return index;
                }
            }
            return -1;
        }
        public void InsertElement(int number, int index)
        {
            if (index>length || index<0)
            {
                throw new IndexOutOfRangeException();
            }
            if (index <= length)
            {
                if(length<capacity-1)
                {
                    for (int i = length + 1; i >= index; i--)
                    {
                        data[i] = data[i - 1];
                    }
                    data[index] = number;
                }
                if (length == capacity-1)
                {
                    int[] newData = new int[capacity*expandCoef];
                    for (int j = 0; j <= length; j++)
                    {
                        newData[j] = data[j];
                    }
                    data = newData;
                    for (int k = capacity; k >= index; k--)
                    {
                        data[k] = data[k - 1];
                    }
                    data[index] = number;
                }
            }
            
        }

        public bool MoveNext()
        {
            if(foreachIndex+1 < length)
            {
                return false;
            }
            else
            {
                foreachIndex++;
                return true;
            }
        }

        public void Reset()
        {
            
        }
    }
}
