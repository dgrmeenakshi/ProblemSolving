
using System.Text;


namespace ProblemSolving.Strings.ChangeStringCase
{
    public class ConvertStringCase
    {
        public void StringCaseConveter(StringBuilder stringToBeConverted)
        {
            // ASCII values  of alphabets: A – Z = 65 to 90, a – z = 97 to 122

            for (int i = 0; i < stringToBeConverted.Length; i++)
            {

                if (stringToBeConverted[i] >= 'a' && stringToBeConverted[i] <= 'z')
                {
                    stringToBeConverted[i] = (char) (stringToBeConverted[i] - 32);
                }
                else if (stringToBeConverted[i] >= 'A' && stringToBeConverted[i] <= 'Z')
                {
                    stringToBeConverted[i] = (char) (stringToBeConverted[i] + 32);
                }


            }

        }
    }
}
