using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample._1022
{
    public class GenericExample
    {
      public void Display()
        {
            int? data = null;

            //Console.WriteLine(data ?? data.Value);

            Student<Guid> student1 = null;
            Person person = new Person()
            {
                Id = 2
            };

            Person person2 = null;
            Console.WriteLine(person.Id);
            Console.WriteLine(person2?.Id);

          //Student<int> student = new Student<int>
          //{
          //    Id = 1,
          //    Name = "Test",
          //};

          //Console.WriteLine(student.Calculate(2,3));

          Student <Guid> student2 = new Student<Guid>()
            {
                Id = Guid.NewGuid(),
                Name = "Test",
            };
        }
    }
}
