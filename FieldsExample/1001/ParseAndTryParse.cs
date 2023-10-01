using System;

namespace FieldsExample._1001
{
    public class ParseAndTryParse
    {
        public void Display()
        {
            string value = "100.23";

            //double convertedValue = double.Parse(value);
            bool status = int.TryParse(value, out int convertedValue);
            if (status)
            {
                Console.WriteLine(convertedValue);
            }
            else
            {
                Console.WriteLine("Not Converted");
            }
           
        }
    }
}
