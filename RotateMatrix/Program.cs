using System;
using System.Linq;

namespace RotateMatrix
{
    class Program
    {
        //Rotate Matrix: Given an image represented by an NxN matrix, where each pixel in the image is 4
        //  bytes, write a method to rotate the image by 90 degrees. (an you do this in place?
        //Zero Matrix: Write an algorithm  such that if an element in an MxN matrix is 0, its entire row and
        //column are set to O.

        static void Main(string[] args)
        {
            string pattern= "aaba";

           var x= pattern.Count();

            Console.WriteLine("Hello World!"+x);
            Console.ReadKey();
        }
    }
}