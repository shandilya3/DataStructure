using System;
using System.Linq;

namespace StrStr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // My solution
            /*  string haystack = "this is the best thing which could happen with her";
              string needle = "happen";

              var x = haystack.Split().ToList();

              if (x.Contains(needle))
              {
                  Console.WriteLine("we found the needle");
              }
              else{
                  Console.WriteLine(-1);
              }*/
            StrStr("sow", "so");
            Console.ReadKey();
        }
        // first approach 

        public static int StrStr( string haystack, string needle)
        {

            if (haystack == null || needle == null)
            {
                return 0;
            }
            if (needle.Length == 0)
            {
                return 0;
            }
            for(int i =0; i<haystack.Length; i++)
            {
                if (i + needle.Length > haystack.Length)
                {
                    return -1;
                }
                int m = i;
                for(int j =0; j<needle.Length; j++)
                {
                    if (needle[j] == haystack[m])
                    {
                        if (j == needle.Length - 1)
                        {
                            Console.WriteLine("found at index =  "+ i);
                            m++;
                            return i;
                            
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return -1;
        }
    }
}
