using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample._0924
{
    internal class StaticModifierExample
    {
        public void Display()
        {
            var std1 = new Student();
            std1._name = "A";
            std1._role = 20;
            std1.Display(std1);

            var std2 = new Student();
            std1._name = "B";
            std1._role = 21;
            std1.Display(std2);

            var std3 = new Student();
            std1._name = "C";
            std1._role = 22;
            std1.Display(std3);

        }
    }
}
