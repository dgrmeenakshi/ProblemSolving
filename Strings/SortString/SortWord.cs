using System;
using System.Linq;
using System.Text;

namespace ProblemSolving.Strings.SortString
{
    public class SortWord
    {
        public void SortTextWithoutInBuiltFunction(StringBuilder stringInput)
        {
            for (int i = 1; i < stringInput.Length; i++)
            {
                var temp = stringInput[i];
                var j = i - 1;
                while (j >= 0 && stringInput[j] > temp)
                {
                    stringInput[j + 1] = stringInput[j];
                    j--;
                }

                stringInput[j + 1] = temp;

            }

            Console.WriteLine(stringInput.ToString());

        }

        public void SortTextWithBuiltInFunction(string stringInput)
        {
            char[] charArray = stringInput.ToCharArray();
            Array.Sort(charArray);
            Console.WriteLine(new string(charArray));

        }

        public void SortTextWithLinq(string stringInput)
        {
            Console.WriteLine(stringInput.OrderBy(x => x.ToString()).ToArray());

        }
    }
}
