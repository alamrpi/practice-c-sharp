using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample._1008
{
    public class PropertiesExample
    {
        public void Display()
        {
            var student = new Student()
            {
                Name = "Test",
            };

         
            Console.WriteLine(student[0]);
        }
    }
}
