using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample._1008
{
    public class ConstructorExample
    {
        public void Display()
        {
            var car = new Car("Sujuki", "Gixxer");
            var car1 = new Car("YAMAHA", "VERSION 3", "Test Motors");
            var car2 = new Car()
            {
                _shopName = "Test",
                brandName = "Test Brand"
            };
        }
    }
}
