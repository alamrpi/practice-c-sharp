using System;

namespace FieldsExample._0930
{
    public class MethodExample
    {
        Student student1 = new Student("Mamun", "Rashid");

        int value = 100;

        public void Display()
        {
            StudentInfo(student1);
            StudentInfo(student1);


            //PrintValue(ref value);

            PrintValue(value, 20, 30, 40, 56);
        }

        public void StudentInfo(Student student)
        {
            Console.WriteLine("Name: " + student.FullName());
            student.FName = "Test";
        }

        //public void PrintValue(ref int value)
        //{
        //    Console.WriteLine(value);
        //    value = 200;

        //}
        public void PrintValue(params int[] values)
        {
            foreach (int value in values) 
                Console.WriteLine(value);
           
        }


        public void PrintValue(int value, string value2)
        {

        }
    }
}
