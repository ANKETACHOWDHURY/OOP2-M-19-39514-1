using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labtask_3
{
    class Account
    {
        string accName;
        string acid;
        int balance;


          public string AccName
          {
              set { accName = value; }
              get { return accName; }
          }
          public string Acid
          {
              set { acid = value; }
              get { return acid; }
          }
        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }
        public Account()
        {
            Console.WriteLine("constructor with empty parameter ");

        }
        public Account(stri, int y, int z)
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
