using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample._0902
{
    public class TypeCastingExample
    {
        public void Display()
        {
            ParenClass parent = new ParenClass();
            parent.Name = "Test";
            parent.RollNO = 20;

            var result = parent.ToString();

            Console.WriteLine(result);

            ParenClass parent1 = new ParenClass();
            parent.Name = "Test";
            parent.RollNO = 20;

            var result1 = parent1.ToString();

            Console.WriteLine(result);
        }

        public void MethodConversion()
        {
            object stringNumberValue = 24;

            string doubleConvertedValue = 24.ToString();
            Console.WriteLine(doubleConvertedValue);
        }
        public void TryParse()
        {
            string numberString = "23";

            bool isConverted = double.TryParse(numberString, out double result);
            if (isConverted)
                Console.WriteLine(result);
            else
                Console.WriteLine("Not Converted");
        }

        public void Parse()
        {
            string numberString = "34.90";

            double convertedValue = double.Parse(numberString);

            Console.WriteLine(convertedValue);
        }
        public void Explicity()
        {
            //double number = 23.012;
            //Console.WriteLine($"double = {number}");
            //int number2 = (int)number;

            //Console.WriteLine($"int = {number2}");

            var childClass = new ChildClass();
            childClass.RegistrationNo = 20;

            ParenClass perentClass = (ParenClass)childClass;

        }
        public void Implicity() {

            int number = 23;
            Console.WriteLine($"int = {number}");
            Console.WriteLine($"int Max size= {sizeof(int)}");
            double number2 = number;

            Console.WriteLine($"Double = {number2}");
            Console.WriteLine($"int Max size= {sizeof(double)}");
            Console.WriteLine(number);
        }
    }


    public class ParenClass
    {
        public string Name { get; set; }
        public int RollNO { get; set; }

        public override string ToString()
        {
            return $"Name = {Name}, Role = {RollNO}";
        }
    }

    public class ChildClass : ParenClass
    {
        public int RegistrationNo { get; set; }
    }

}
