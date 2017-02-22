using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringProblems;

namespace RunProgram_UnitTest
{
    [TestClass]
    public class StringClass_reverseWordMethod
    {
        [TestMethod]
        public void TestMethod_firstNonRepeatedChar_PositiveTestCase()
        {
            char expected = 'P';
            char chResult = StringProblems.Strings.firstNonRepeatedChar("Parikshit");
            Assert.AreEqual(expected, chResult);
        }
    }
}
