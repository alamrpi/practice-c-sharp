using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee.Interfaces;
using Employee;
using static System.Console;
using static Employee.Test;
using Employee.Classes;

namespace FieldsExample._1015
{
    public class NameSpaceExample
    {
        public NameSpaceExample(IEmployeeService employeeService)
        {
           
        }
        public void Display()
        {
            var car = new Car();

            var employee1 = new Employee.Classes.EmployeeService();
            employee1.EmployeeType = EmployeeType.FullTime;

            var employee2 = new Employee.Classes.EmployeeService();
            employee1.EmployeeType = EmployeeType.PartTime;

            WriteLine();

            TestMethod1();
            TestMethod2();
            TestMethod3();
            TestMethod4();

        }
    }
}
