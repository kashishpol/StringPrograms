using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringProblems;

namespace RunProgram_UnitTest
{
    [TestClass]
    public class StringsClass_isPalindromMethod
    {
        [TestMethod]
        public void TestMethod_isPalindromStringNull()
        {
           bool result= StringProblems.Strings.isPalindrome(null);
           Assert.IsFalse(result);
        }
    }
}

