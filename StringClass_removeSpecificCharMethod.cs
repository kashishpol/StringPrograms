using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringProblems;

namespace RunProgram_UnitTest
{
    [TestClass]
    public class StringClass_removeSpecificCharMethod
    {
        [TestMethod]
        public void StringClass_removeSpecificCharMethod_PositiveTestCase()
        {
            string expected = "Sele";
           string result= StringProblems.Strings.removeSpecificChar("Seattle is a city", " is a city");
           Assert.AreEqual(expected, result);
        }
    }
}
