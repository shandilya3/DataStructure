using System;

namespace MoreStringBased
{
    class Program
    {
//        Is Unique: Implement an algorithm to determine if a string has all unique characters.What if you
//cannot use additional data structures?
        static void Main(string[] args)
        {
           
            string[] words = { "bbcde", "hello", "apple", "kite", "padle" };

            foreach (var word in words)
            {
                Console.WriteLine(word + ": " + IsUnique(word) );
            }

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
        // first way
        public static bool IsUnique( string str)
        {
            if (str.Length > 256)
            {
                return false;
            }
            int checker = 0;
            for (int i = 0; i<str.Length; i++)
            {
                var val = str[i] - 'a';

                if ((checker & (1<<val))>0)
                {
                    return false;
                }
                // compound bitWise OR(|=) operator   x|=y  is equivalent to  x = x | y 
                checker |= (1<<val);
            }
            return true;
        }

        //Second way

        //public static bool IsUniqueChar(string str)
        //{
        //    if (str.Length>256)
        //    {
        //        return false;
        //    }


        //    var charSet = new bool[256];

        //    for (var i = 0; i < str.Length; i++)
        //    {
        //        int val = str[i];

        //        if (charSet[val])
        //        {

        //            return false;
        //        }

        //        charSet[val] = true;
        //    }

        //    return true;
        //}

    }
}