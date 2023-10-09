using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample._1009
{
    public class ChildClass : ParentClass
    {
        public new void Display()
        {
            Console.WriteLine("Hello From Child");
        }

        public override void DisplayForOverriding()
        {
            base.DisplayForOverriding();
            Console.WriteLine("Hello From Child");
        }
    }
}
