

using System;

namespace ProblemSolving.Problems
{
    public class ReverseAString
    {
        public string ReverseWordsInString(string inputString)
        {
            string output = string.Empty;
            string[] splitStrings = inputString.Split(' ');
            for (int i = splitStrings.Length - 1; i > -1; i--)
            {
                output = output + splitStrings[i] + " ";
            }
            return output;
        }

        public string ReverseFullSentence(string inputString)
        {
            string[] splitStrings = inputString.Split(' ');
            string output = string.Empty;
            for (int i = 0; i < splitStrings.Length - 1; i++)
            {
                output = output + ReverseString(splitStrings[i]) + " ";
            }

            return output;
        }
        private static string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }

}
