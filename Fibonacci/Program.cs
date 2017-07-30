using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            GetNthFibonacciNumber(6);
            Console.WriteLine(GetNthFibonacciNumber(6));
            Console.WriteLine("After DP solution");
            GetNthFibonacciyWithDP(6);
            Console.WriteLine(GetNthFibonacciyWithDP(6));
            Console.WriteLine("After DP n reduce space solution");
            Console.WriteLine(GetNthFibonacciyWithDPReducedSpace(9));
          
            Console.ReadKey();
        }
        // Method 1 Recursion which has  exponenetial time space complexity
         
       public static int GetNthFibonacciNumber(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            return GetNthFibonacciNumber(n-1) + GetNthFibonacciNumber(n-2);
        }

        // Method 2 Recursion with Memoization which is also called Dynamic Programming solution
        // Which reduces the linear time complexity but not the space complexity

        public static int GetNthFibonacciyWithDP(int n)
        {
            int[] f = new int[n+1];
            f[0] = 0;
            f[1] = 1;
                for (int i = 2; i <= n; i++)
                {
                    f[i] = f[i - 1] + f[i - 2];         
                }
            return f[n];
        }
        // to reduce space complexity
        public static int GetNthFibonacciyWithDPReducedSpace(int n)
        {
            int a = 0, b = 1, c;
            if (n == 0)
                return a;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
            return b;
        }
    }
}