using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample._1009
{
    public class Teacher : Person
    {
        public Teacher(string name, string phoneNumber, string email) : base(name, phoneNumber, email)
        {
           
        }
        public Teacher(string name, string phoneNumber, string email, string designation):this(name, phoneNumber, email)
        {
            Designation = designation;
        }
        public string Designation { get; set; }

        ////Base keyword is optional if the name is not ambiguity.
        //public void Display()
        //{
        //    Console.WriteLine(Name);
        //}
        //Use of 'base' keyword
        //public string Name { get; set; }
        //public void Display()
        //{
        //    Console.WriteLine(base.Name);
        //}
    }
}
