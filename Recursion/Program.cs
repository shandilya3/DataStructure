using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {

            // Recursive way 

            Console.WriteLine("Enter the length of the Fibonacci Series ");

            var x = Console.ReadLine();
            int length = Convert.ToInt32(x); ;
            for (int i  =0; i< length; i++)
            {
                 Console.WriteLine("value"+FibonacciSeries(i));
            }




            //FibonacciSeries();
            Console.WriteLine("Hello World!");
            //GenerateFibonachi(7);
            Console.ReadKey();
        }
         // recursive

        public static int FibonacciSeries(int n)
        {
            if (n == 0) return 0; //To return the first Fibonacci number   
            if (n == 1) return 1; //To return the second Fibonacci number   
            return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
          
        }



      /*  // Fibonacchi using iteration
        static void  GenerateFibonachi(int len)
        {
            int a = 0, b = 1, c = 0;

            for (int i= 2; i<len; i++)
            {
                c = a + b;
                Console.WriteLine("{0}", c);
                a = b;
                b = c;
            }


        }*/
    }
}
