using System;
using System.Collections.Generic;
using System.Linq;

namespace PatternMatching
{
    class Program
    {
       public static void Main(string[] args)
        {

            /* 459.Repeated Substring Pattern

               Given a non-empty string check if it can be constructed by taking a substring of it and appending multiple copies of the substring together. 
               You may assume the given string consists of lowercase English letters only and its length will not exceed 10000.

                                        Example 1:
                                        Input: "abab"

                                        Output: True

                                        Explanation: It's the substring "ab" twice.
                                        Example 2:
                                        Input: "aba"

                                        Output: False
                                        Example 3:
                                        Input: "abcabcabcabc"

                                        Output: True

                                       Explanation: It's the substring "abc" four times. (And the substring "abcabc" twice.)*/




            Console.WriteLine("Hello World!");



















            // pattern Matching 
            string pattern = "aaggbat";
            string text = "happy happy adi happy";

            Console.WriteLine("Hello World!");
            Program obj = new Program();
            MatchAlgo(pattern, text);


        }
        public static bool MatchAlgo(string pattern, string text)
        {
            var result = text.Split(' ').ToList();

            var mapPattern = new Dictionary<char, string>();

            if(result.Count != pattern.Count())
            {
                return false;
            }
            string matchstr;
            int index = 0;
            foreach (var c in pattern)
            {
                if (mapPattern.TryGetValue(pattern[index], out matchstr))
                {
                    if (matchstr != result[index])
                    {
                        Console.WriteLine("in the fasle");
                        return false;
                    }

                }

                else
                {
                    if (mapPattern.ContainsValue(result[index]))
                    {
                        Console.WriteLine("False outside");
                        return false;
                    }
                    mapPattern.Add(c, result[index]);
                }
                    ++index;
            }
            
            Console.WriteLine("in the matchPattern");
            Console.ReadKey();
            return true;
        }

      

    }
}
 