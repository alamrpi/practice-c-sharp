using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample._1022
{
    public class Student<T>
    {
        public T Id { get; set; }
        public string Name { get; set; }

        //public TResult Calculate<T1, TResult>(T1 a, T1 b)
        //{
        //    return TResult;
        //}
    }

    public class Person
    {
        public int Id { get; set; }
    }

    public class Teacher: Person
    {

    }
}
