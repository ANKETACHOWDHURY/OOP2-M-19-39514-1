using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labtask_3
{
    class Triangle
    {
        int x;
        int y;
        int z;

        public int X
        {
            set { x = value; }
            get { return x; }
        }
        public int Y
        {
            set { y = value; }
            get { return z; }
        }
        public int Z
        {
            set { z = value; }
            get { return z; }
        }
        public Triangle()
        {
            Console.WriteLine("constructor with empty parameter ");

        }
        public Triangle(int x, int y, int z)
        {
            Console.WriteLine("Constructor with 3 parameter ");
            this.x = x;
            this.y = y;
            this.z = z;

        }
        public void ShowInfo()
        {
            Console.WriteLine("X is: " + x);
            Console.WriteLine("Y is: " + y);
            Console.WriteLine("Z is: " + z);
        }
     



    }
}
