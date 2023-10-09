using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample._1009
{
    public class Person
    {
        public Person()
        {
            
        }
        public Person(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

    }
}
