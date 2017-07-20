using System;

namespace ValidPalindrom
{
    class Program
    {
        /*125. Valid Palindrome
          Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.

                        For example,
                        "A man, a plan, a canal: Panama" is a palindrome.
                        "race a car" is not a palindrome.*/


        static void Main(string[] args)
        {



            string givenString = "A man, a plan, a canal: Panama";

            char[] resultedArray = givenString.ToCharArray();

            int len = resultedArray.Length;

            int count = 0;

            for (int i = 0; i<len/2; i++)
            {
                if (resultedArray[i] == resultedArray[len-i-1])
                {
                    count++;
                }

            }

            if(count == len / 2)
            {
                Console.WriteLine("this is a palindrome ");
            }
            else
            {
                Console.WriteLine("this is not a palindrome");
            }




            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}