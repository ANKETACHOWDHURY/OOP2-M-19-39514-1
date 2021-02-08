using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labtask_3
{
        class student
        {
            string name;
            string id;
            string department;
            float cgpa;

            public string Name
            {
                set { name = value; }
                get { return name; }
            }

            public string Id
            {
                set { id = value; }
                get { return id; }
            }
            public string Department
            {
                set { department = value; }
                get { return department; }
            }
            public float Cgpa
            {
                set { cgpa = value; }
                get { return cgpa; }
            }


            public student()
            {
                Console.WriteLine("constructor with empty parameter ");

            }
            public student(string name, string id, string department)
            {
                Console.WriteLine("Constructor with 3 parameter ");
                this.name = name;
                this.id = id;
                this.department = department;

            }
            public void ShowInfo()
            {
                Console.WriteLine("Name is: " + name);
                Console.WriteLine("Id is: " + Id);
                Console.WriteLine("Department is: " + department);
                Console.WriteLine("Cgpa is: " + cgpa);
            }







        }
    
}
