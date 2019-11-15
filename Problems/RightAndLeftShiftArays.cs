namespace ProblemSolving
{
    public class RightAndLeftShiftArays
    {
        // Input - a1= abcde , LeftShift by 2 = cdeab , RightShift by 2 = deabc 

        public string ShiftsInStringArrays(int rightShifts, int leftShifts, string input)
        {
            var result = RightShiftsWithBuiltInFunc(input, rightShifts);
            return LeftStringSiftWithBuiltInFunc(result, leftShifts);
        }

        private string LeftStringSiftWithBuiltInFunc(string a, int shifts)
        {
            string result = a.Substring(shifts, a.Length - shifts) + a.Substring(0, shifts);
            return result;
        }

        private string RightShiftsWithBuiltInFunc(string a, int shifts)
        {
            string result = a.Substring(a.Length - shifts, shifts) + a.Substring(0, a.Length - shifts);
            return result;
        }

        private char[] LeftShiftString(string a, int LeftShifts)
        {
            char[] ch = a.ToCharArray();
            for (int i = 0; i < LeftShifts; i++)
            {
                char fistChar = ch[0];
                for (int j = 1; j <= ch.Length - 1; j++)
                {
                    ch[j - 1] = ch[j];
                }

                ch[ch.Length - 1] = fistChar;
            }
            return ch;

        }
        public int[] LeftShiftArray(int[] intArray, int leftShifts)
        {

            for (int i = 0; i < leftShifts; i++)
            {
                int fistDigit = intArray[0];
                for (int j = 1; j <= intArray.Length - 1; j++)
                {
                    intArray[j - 1] = intArray[j];
                }

                intArray[intArray.Length - 1] = fistDigit;
            }

            return intArray;

        }

    }
}

