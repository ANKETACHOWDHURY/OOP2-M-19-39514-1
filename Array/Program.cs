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
            Console.WriteLine("Sum of the array elements is : {0}", sum  );

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

        }
    }
}
