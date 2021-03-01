using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Anketa", "2564456", 3.5f);
            Student s2 = new Student("Arpita", "45688975", 2.5f);
            Student s3 = new Student("Tushti", "1268894", 3.45f);

            Department d1 = new Department("OOP 2", "CS");
            Department d2 = new Department("English", "BBA");

            s1.Dept = d1;
            d1.AddStudent(s1, s2, s3);
            d1.AddStudent(s2);
            s2.Dept = d2;

            s1.ShowSudentDeatils();
            s3.ShowSudentDeatils();
            Console.WriteLine("***************");
            d1.Name = "Computer Science and Engineering";
            d1.Id = "CSE";
            s2.ShowSudentDeatils();
        }
    }
}
