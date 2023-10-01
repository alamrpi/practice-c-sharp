using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample._1001
{
    public class ImplicityCast
    {
       public void Display()
       {
            int testValue = 20;
            Console.WriteLine(testValue);
            decimal convertedValue;
            convertedValue = testValue;
            Console.WriteLine(convertedValue);
       }
    }
}
