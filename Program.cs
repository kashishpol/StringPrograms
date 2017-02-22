using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringProblems;

namespace RunProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = StringProblems.Strings.isPalindrome("Kashish");
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
