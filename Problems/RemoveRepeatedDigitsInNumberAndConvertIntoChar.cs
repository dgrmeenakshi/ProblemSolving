using System;
using System.Collections;

/* Input an Integer unsorted Array ie - {1,2,3,4,13,4,34}  and Output {A,B,C,D,M}- should contain distinct char values.
 if sum of adjacent int are > 25 then no print
 */

namespace ProblemSolving.Problems
{
    public class RemoveRepeatedDigitsInNumberAndConvertIntoChar
    {
        public static ArrayList DistinctWordsInIntArray(int[] arr)
        {
          return  MapIntToChar(RemoveDuplicatesFromArray(arr));
        }


        public static int[] RemoveDuplicatesFromArray(int[] arr)
        {
            var arrayList = new ArrayList(arr);
            arrayList.Sort();
            for (int i = 0; i < arrayList.Count - 1; i++)
            {
                if (arrayList[i].Equals(arrayList[i + 1]))
                {
                    arrayList.RemoveAt(i);
                }
            }

            arrayList.Add(arrayList[arrayList.Count - 1]);

            int[] array = arrayList.ToArray(typeof(int)) as int[];
            return array;
        }

        public static ArrayList MapIntToChar(int[] arrList)
        {
            ArrayList stringArray = new ArrayList();
            for (int i = 0; i < arrList.Length-1; i++)
            {
                if(arrList[i]+arrList[i+1] < 25)
                stringArray.Add(Convert.ToChar(64 + arrList[i+1]));
            }
          return new ArrayList(stringArray);
        }


    }
}
