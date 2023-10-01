using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample._1001
{
    public class ExplicityCast
    {
        public void Display()
        {
            double testValue = 20.56;
            Console.WriteLine(testValue);
            int convertedValue;
            convertedValue = (int)testValue;
            Console.WriteLine(convertedValue);
        }
    }
}
