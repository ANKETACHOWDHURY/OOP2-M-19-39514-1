using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LabTask_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("ad", "1254", "CSE", 3.45f);
            s1.ShowInfo();

            Triangle t1 = new Triangle(10, 15, 20);
            t1.TestTriangle();

            Account a1 = new Account("xyz", "4562", 5000);
            a1.Deposit(500);
            a1.Withdraw(100);

            Course c1 = new Course("Physics", "103", 3);
            c1.ShowCourseInfo();

        }


    }
}
