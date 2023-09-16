using FieldsExample._0902;
using FieldsExample._0916;
using System;

namespace ValueTypeParameter
{
    class Sample
    {
        static void Main()
        {
          //  string firstName = "Test";
          //  var typeCast = new TypeCastingExample();
          //  typeCast.Display();

          //  var std1 = new Student("Masud", "Rana", 01);
          //  std1.Display();

          //  var std2 = new Student("Ali", "Mahmud", 02);
          //std2.Display();

            var std3 = new Student()
            {
                _firstName = "Test",
                _lastName = "Test r",
              
            };
            std3.Display();

            Console.ReadKey();
        }
    }
}

