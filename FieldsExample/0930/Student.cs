using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FieldsExample._0930
{
    public class Student
    {
        public Student(string fName, string LName)
        {
            this.FName = fName;
            this.LName = LName;
        }
        public string FName { get; set; }
        public string LName { get; set; }

        public string FullName()
        {
            return FName + " " + LName;
        }

    }

    
}
