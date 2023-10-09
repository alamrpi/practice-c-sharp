using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample._1009
{
    public class ParentClass
    {
        public void Display()
        {
            Console.WriteLine("Hello From Parent");
        }

        public virtual void DisplayForOverriding()
        {
            Console.WriteLine("Hello From Parent");
        }
    }
}
