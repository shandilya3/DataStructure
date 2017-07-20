using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseWordsInString
{
    class Program
    {
      
        static void Main(string[] args)
        { 
            // reverse words in a string 
                                    string text = "the sky is blue";

                                    string[] words = text.Split(' ');

                                    foreach (var w in words)
                                    {
                                        Console.WriteLine(w);
                                    }
                                    StringBuilder sb = new StringBuilder();

                                    for (int i = words.Length - 1; i >= 0; i--)
                                    {
                                        sb.Append(words[i]);
                                        sb.Append(" ");
                                    }
                                    Console.WriteLine(sb);
            // reverse words in a string through two pointer 

                                string tempWord;
                                 int length = words.Length;
                                  Console.WriteLine(length);
                                 for(int i =0; i<length; i++)
                                 {
                                     tempWord = words[i];


                                    words[i] = words[length - i - 1];
                                    words[length - i - 1] = tempWord;
                                 }
                                 foreach( var w in words)
                                 {
                                     Console.WriteLine(w);
                                 }

            // reverse a string 
                                    string s = "hello";
                                    char[] res = s.ToCharArray();
                                    StringBuilder sb1 = new StringBuilder();
                                    for( int j=(res.Length)-1; j>=0; j--)
                                    {
                                        sb1.Append(res[j]);
                                    }
                                    Console.WriteLine(sb1);
          
                                    // two pointer
                                    char temp;
                                    int len = res.Length;
                                    for(int i=0; i< len; i++)
                                    {
                                        temp = res[i];
                                        res[i] = res[len - i-1];
                                        res[len-i-1] = temp;
                                    }
                                   foreach(var c in res)
                                    {
                                        Console.WriteLine(c);
                                    }
            /*  345. Reverse Vowels of a String
                  Write a function that takes a string as input and reverse only the vowels of a string.

                     Example 1:
                     Given s = "hello", return "holle".

                     Example 2:
                     Given s = "leetcode", return "leotcede".*/

            // reverse Vowels of a string 

         
            
            string word = "hello";
            int wordLen =word.Length;
            char[] wordArray = word.ToCharArray();
           
            for(int k = 0; k< wordLen/2; k++)
            {

                if (IsVowel(wordArray[k]) && IsVowel(wordArray[wordLen - k - 1]))
                {
                    char temp1;
                    temp1 = wordArray[k];
                    wordArray[k] = wordArray[wordLen - k - 1];
                    wordArray[wordLen - k - 1] = temp1;
                }
            }

            foreach (var c in wordArray)
            {
                Console.WriteLine("string after reversing vowels in the string is " +c);
            }

            Console.ReadKey();
        }


            public  static bool IsVowel(char a)
            {

                if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
    }
}