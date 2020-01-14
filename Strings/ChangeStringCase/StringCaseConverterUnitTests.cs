using System;
using System.Text;
using NUnit.Framework;

namespace ProblemSolving.Strings.ChangeStringCase
{

    [TestFixture]
    public class StringCaseConverterUnitTests
    {
        [Test]
        public void VerifyChangeStringLowerToUpperCase_StringChangedfromLowerToUpper()
        {
            StringBuilder input = new StringBuilder("eee");
            ConvertStringCase stringCase = new ConvertStringCase();
            stringCase.StringCaseConveter(input);
            Assert.AreEqual("EEE",input.ToString());

        }
    }
}
