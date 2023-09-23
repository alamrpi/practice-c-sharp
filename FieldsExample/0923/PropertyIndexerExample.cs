using System;
using System.Reflection;

namespace FieldsExample._0923
{
    public class PropertyIndexerExample
    {
        public void Display()
        {
            //var employee = new Employee();
            //employee.Salary = 10000;

            //Console.WriteLine(employee.Salary);
            var byke = new Byke();

            byke["first"] = "KTM";
            

            Console.WriteLine(byke["first"]);
        }
    }

    public class Byke
    {
        private string[] _brands = new string[] { "Honda", "Suzuki", "Hero" };
        private string[] _position = new string[] { "first", "Second", "third" };

        public string this[int index]
        {
            get
            {
                return _brands[index];
            }
            set
            {
                _brands[index] = value;
            }
        }

        public string this[string name]
        {
            get
            {
                return _brands[Array.IndexOf(_position, name)];
            }
            set
            {
                _brands[Array.IndexOf(_position, name)] = value;
            }
        }

    }

    public class Employee
    {
        // private double _salary;

        //public double Salary
        //{
        //    set
        //    {
        //        _salary = value;
        //    }
        //    get
        //    {
        //        return _salary;
        //    }
        //}

        public double Salary { get; set; } = 300;

    }
}
