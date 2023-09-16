using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample._0916
{
    public class Student
    {
       public string _firstName;
       public string _lastName;
       public int _rollNumber;

        //public Student() { 
        //}
        //public Student(string firstName, string lastName)
        //{
        //    if(!string.IsNullOrEmpty(firstName))
        //    {
        //        _firstName = firstName;
        //    }
        //    else
        //    {
        //        _firstName = "default";
        //    }

        //   _firstName = firstName;
        //   _lastName = lastName;
        //}

        //public Student(int rollNumber)
        //{
        //    _rollNumber = rollNumber;
        //}

        public void Display()
        {
            Console.WriteLine(_firstName + " " + _lastName);
            Console.WriteLine("Role: "+_rollNumber);
        }

    }
}
