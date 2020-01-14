
namespace ProblemSolving.Sort
{  
    public class InsertionSort
    {
        public void InsertSortAlgorithm(int[] inputToBeSorted)
        {
            for (int i = 1; i < inputToBeSorted.Length; i++)
            {
                var temp = inputToBeSorted[i];
                var j = i - 1;
                while (j >= 0 && inputToBeSorted[j] > temp)
                {
                    inputToBeSorted[j + 1] = inputToBeSorted[j];
                    j--;
                }

                inputToBeSorted[j + 1] = temp;
            }
        }
    }
}
