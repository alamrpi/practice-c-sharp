using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample._1014
{
    public abstract class Person
    {
        public string FName { get; set; }

        public abstract string GetFullName(string lastName);

    }
}
