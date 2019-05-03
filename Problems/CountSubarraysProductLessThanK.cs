

namespace ProblemSolving.Problems
{
    public class CountSubarraysProductLessThanK
    {
        public static int SubarrysCountProductLessThanK(int[] n, int k)
        {
            int count = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] < k)
                {
                    count++;
                }
                var curMul = n[i];
                for (int j = i + 1; j < n.Length; j++)
                {
                    curMul = curMul * n[j];
                    if (curMul < k)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return count;
        }
    }
}
