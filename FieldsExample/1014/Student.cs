using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample._1014
{
    public class Student : Person
    {
        public Student()
        {
            FName = "Test";
        } 

        public override string GetFullName(string lastName)
        {
            return FName + " " + lastName;
        }
    }
}
