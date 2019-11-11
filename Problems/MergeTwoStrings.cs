using System.Text;

namespace ProblemSolving.Problems
{
    public class MergeTwoStrings
    {
        // Merge two string of different lengths s1- abc, s2- de then output= adbec
        public string MergeStrings(string s1, string s2)
        {
            var maxLength = s1.Length > s2.Length ? s1.Length : s2.Length;
            var stringBuilder = new StringBuilder();
            for (var i = 0; i < maxLength; i++)
            {
                if (i < s1.Length) stringBuilder.Append(s1[i]);

                if (i < s2.Length) stringBuilder.Append(s2[i]);
            }

            return stringBuilder.ToString();
        }
    }
}