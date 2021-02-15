using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 15, 20, 25, 30, 35 };
            Console.Write("The reverse value of the array is : ");

            for (int i = arr1.Length; i > 0; i--)
            {
                Console.Write(arr1[i - 1] + " ");
            }
            Console.WriteLine();

            int sum = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                sum = sum + arr1[i];
            }
            Console.WriteLine("Sum of the array elements is : {0}", sum);

            int[] arr2 = new int[5];
            Console.Write("Copy Array Elements : ");
            for (int k = 0; k < arr1.Length; k++)
            {
                arr2[k] = arr1[k];
            }
            for (int l = 0; l < arr2.Length; l++)
            {
                Console.Write(arr2[l] + " ");
            }
            Console.WriteLine();

            int[] arr3 = { 9, 9, 4, 3, 15, 15, 5, 6, 6, 7,20,30 };
            for (int m = 0; m < arr3.Length; m++)
            {
                for (int n = m + 1; n < arr3.Length; n++)
                {
                    if (arr3[m] == arr3[n])
                        Console.WriteLine("Number {0} has a duplication.", arr3[m]);
                }
            }
            Console.WriteLine();

        }
    }
}
