using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSolving.Problems;

namespace ProblemSolving.Sort
{
   public class BubbleSort
    {
        public void Sort(int[] Input)
        {
            int size = Input.Length;
            for (int k = 0; k < size - 1; k++)
            {
                for (int i = 0; i < size - 2; i++)
                {
                    if (Input[i] > Input[i + 1])
                    {
                        Swap(Input, i, i+1);
                    }
                    
                }
            }
     
        }

        private static void Swap(int[] array, int index, int nextElementIndex)
        {
            array[index] = array[index] + array[nextElementIndex];
            array[nextElementIndex] = array[index] - array[nextElementIndex];
            array[index] = array[index] - array[nextElementIndex];
        }
    }
}
