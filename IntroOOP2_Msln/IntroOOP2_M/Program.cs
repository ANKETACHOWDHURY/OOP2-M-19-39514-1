using System;

namespace IntroOOP2_M
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 9;
            
            Console.WriteLine("Addition of x and y is {0}", x+y);
            Console.WriteLine("Subtraction of x and y is {0}", x-y);
            Console.WriteLine("Multiplication of x and y is {0}", x*y);
            Console.WriteLine("Divition of x and y is {0}", x / y);
            Console.WriteLine("The number of the w is:");
            int w = int.Parse(Console.ReadLine());         
        }
    }
}
