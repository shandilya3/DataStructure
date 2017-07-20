using System;

namespace RotateAnArrayByKthStep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] givenArray= new int[] {1,2,3,4,5,6,7 };
            
            //  rotate by 3 indexes so the resulting array is { 5,6,7, 1, 2,3,4}
            int len = givenArray.Length;
            int kth = 3;
            int[] arr1 = new int[kth + 1];
            int[] arr2 = new int[kth];
            int temp;
            for(int i =0; i <=kth; i++)
            {
               arr1[i] = givenArray[i];
            }
            for (int i = kth+1; i <len; i++)
            {
                arr2[i] = givenArray[i];
            }

            foreach (var c in givenArray)
            {
                Console.WriteLine(c);
            }

        }
    }
}