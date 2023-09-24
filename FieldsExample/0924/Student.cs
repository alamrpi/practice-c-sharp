using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample._0924
{
    public class Student
    {
        public readonly string _instituteName = "DIU";

        public string _name;
        public int _role;

        public void Display(Student student)
        {
            Console.WriteLine("Institute : {0}", _instituteName);
            Console.WriteLine("Name : {0}", student._name);
            Console.WriteLine("Role : {0}", student._role);
        }
    }
}
