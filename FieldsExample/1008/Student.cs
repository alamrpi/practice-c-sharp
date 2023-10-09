using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample._1008
{
    public class Student
    {
        private string _id;
        private string _name;
        private string[] _skills = new string[] { "C#", "ASP.NET", "MSSQL"};

        public Student()
        {
            _id = Guid.NewGuid().ToString();
        }

        public string Name
        {
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");

                _name = value;
            }

            get
            {
                return _name;
            }
        }

        public string Email{set;get;}
        public string Phone { get; set; } = "+880170000000";

        public string this[int index]
        {
            set
            {
                _skills[index] = value;
            }
            get
            {
                return _skills[index];
            }
        }
    }
}
