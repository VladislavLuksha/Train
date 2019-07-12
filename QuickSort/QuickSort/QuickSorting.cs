using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class QuickSorting
    {
        int[] array;
        int size;
        public QuickSorting(int size)
        {
            this.size = size;
            array = new int[size];
        }
        public void InitializationArray()
        {
            Random random = new Random();
            for(int i=0;i<size;i++)
            {
                array[i] = random.Next(1, 20);
            }
        }
        public void ArrayPrinting()
        {
            foreach(int element in array)
            {
                Console.WriteLine(element);
            }
        }

        public int SelectionOfTheSupportElement(int startIndex,int endIndex)
        {
            Random ran = new Random();
            int index = ran.Next(startIndex, endIndex);
            return index;
        }

        public void QuickArraySorting(int startIndex, int endIndex)
        {
            int i = startIndex, j = endIndex;

            int index = SelectionOfTheSupportElement(i, j);
            while (i < j)
            {
                while (array[i] <= array[index] && i < index)
                    i++;
                while (array[j] >= array[index] && j > index)
                    j--;
                if (array[i] > array[j])
                {
                    int exchangeVariable = array[i];
                    array[i] = array[j];
                    array[j] = exchangeVariable;
                }
            }
            if(startIndex<j)
            {
                QuickArraySorting(startIndex, j);
            }
            if(i<size-1)
            {
                QuickArraySorting(i,size-1);
            }
        }
    }
}
