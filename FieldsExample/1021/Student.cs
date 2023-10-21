using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample._1021
{
    public class Student
    {
        public string Name { get; set; }
        public string RegName { get; set; }
        public Student(string name, string regName)
        {
            Name = name;
            RegName = regName;
        }

        public override bool Equals(object obj)
        {
            Student s = obj as Student;
            if (s.Name == Name && s.RegName == RegName)
                return true;
            else 
                return false;
        }
    }
}
