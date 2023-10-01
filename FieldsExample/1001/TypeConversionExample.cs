using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample._1001
{
    internal class TypeConversionExample
    {
        ExplicityCast explicityCast = new ExplicityCast();
        ParseAndTryParse parseTryParse = new ParseAndTryParse();
        ConversionMethod conversionMethod = new ConversionMethod();
        public void Display()
        {
            //implicityCast.Display();
            //explicityCast.Display();
            //parseTryParse.Display();
            conversionMethod.Display();
        }
    }
}
