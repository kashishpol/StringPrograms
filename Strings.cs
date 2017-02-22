using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace StringProblems
{
    public class Strings
    {

        //method to find if the string is palindrome
        public static bool isPalindrome(string s)
        {
            if(s==null)
            {
                System.Console.WriteLine("string is null");
                return false;
            }
            string s2 = s.ToLowerInvariant(); 
            int len = s.Length;
            
            for (int i = 0, j = len - 1; j > (len - 1) / 2; i++, j--)
            {
                
                if (s2[i] == s2[j])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }



        // method to find first non repeated character in given string
        public static char firstNonRepeatedChar(string s)
        {
            int len = s.Length;
            char[] ch = s.ToCharArray();
            int val;
            Hashtable ht = new Hashtable();
            for(int i=0;i<len;i++)
            {
                if (ht[ch[i]]==null)
                {
                    ht.Add(ch[i], 1);
                }
               
                else
                {
                    val = (int)ht[ch[i]];
                    ht[ch[i]] = val;
                    
                }
            }
            for(int j=0;j<len;j++)
            {
                if((int)ht[ch[j]]==1)
                {
                    return ch[j];
                }
            }
            return '\0';
        }


        //method for removing specific character or substring from the string
         
        public static string removeSpecificChar(string s1, string s2)
        {
            char[] source = s1.ToCharArray();
            char[] removeChar = s2.ToCharArray();
            bool[] flags = new bool[128];

            int sourceLen = s1.Length;
            int removecharLen = s2.Length;

            for(int i=0;i<removecharLen;i++)
            {
                flags[removeChar[i]] = true;
            }

            int start = 0,dst=0;
            while (start<sourceLen)
            {
                if(!flags[source[start]])
                {
                    source[dst++] = source[start];
                }
                ++start;
            }
            string str = new string(source, 0, dst);
            return str;
           
        }


        //method to reverse word in place

        public static string reverseWord(string s)
        {
            int len = s.Length;
            int start=0 , end=0;
            reverseString(s, 0, len-1);
            while(end<len)
            {
                if(s[end]!=' ')
                 {
                    start = end;
                    if(s[end]!=' '&& s[end]<len)
                    {
                       end++;
                    }
                    
                    end--;
                    reverseString(s, start, end);
                  }
                end++;

              }
            return s;
         }

                   
        //method to reverse string in place
        public static void reverseString(string s,int start,int end)
        {
            char[] chArr= s.ToCharArray();
            int mid = ((s.Length) + 1 )/ 2;
            char temp;
            for (int i = 0; i >= mid; i++)
            {
                temp = chArr[start];
                chArr[start] = chArr[end];
                chArr[end] = temp;
            }
            
        }











        
    }
}