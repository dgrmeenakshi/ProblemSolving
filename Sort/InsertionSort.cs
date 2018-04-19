using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvings
{
    public class InsertionSort
    {
        public void Sort(int[] array)
        {
            int size = array.Length;
            for (int index = 0; index < size; index++)
            {
                for (int nextElementIndex = index + 1; nextElementIndex < size; nextElementIndex++)
                {
                    if (array[index] > array[nextElementIndex])
                    {
                        swap(array, index, nextElementIndex);
                    }
                }

            } 
        }

        private static void swap(int[] array, int index, int nextElementIndex)
        {
            array[index] = array[index] + array[nextElementIndex];
            array[nextElementIndex] = array[index] - array[nextElementIndex];
            array[index] = array[index] - array[nextElementIndex];
        }

     
     

    }
}
