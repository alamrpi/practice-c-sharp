using System;

namespace FieldsExample._1001
{
    public class ConversionMethod
    {
        public void Display()
        {
            string value = "100.23";

            decimal convertedValue = Convert.ToDecimal(value);
            Console.WriteLine(convertedValue);
        }
    }
}
