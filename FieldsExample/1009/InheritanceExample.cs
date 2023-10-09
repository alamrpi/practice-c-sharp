using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample._1009
{
    public class InheritanceExample
    {
        public void Display()
        {
            var teacher = new Teacher("Mamun", "xxxxxx", "test@gmail.com");
            var student = new Student();
            //var person = new Person();

            var child = new ChildClass();
            child.DisplayForOverriding();
            
        }
    }
}
