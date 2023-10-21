using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample._1021
{
    internal class StructureExample
    {
        public void Display()
        {
            double data = 1000;
            
            Student student1 = new Student("test", "3737");
           
            Student student2 = new Student("test", "3737");
            Student student3 = student2;

            //Console.WriteLine(student2.Equals(student1));

            //Console.WriteLine(student1.GetHashCode());
            //Console.WriteLine(student3.GetHashCode());

            Console.WriteLine(student1.GetType());


            //Console.WriteLine(data);
            //Console.WriteLine(student.Name);

            //var car = new Car(2, "Toyota");
            //Console.WriteLine(car._id);
            //Console.WriteLine(car._name);

            //changeValue(car, student);
            //Console.WriteLine("Befor Method Calling");
            //Console.WriteLine(data);
            //Console.WriteLine(student.Name);

            //Console.WriteLine(car._id);
            //Console.WriteLine(car._name);
        }

        public void changeValue(Car car, Student student)
        {
            car._id = 5;
            car._name = "Yamaha";

            student.Name = "Test2";
        }
    }
}
