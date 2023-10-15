using Employee.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    namespace Classes
    {
        public class EmployeeService : IEmployeeService
        {
            public EmployeeType EmployeeType { get; set; } 
            public string GetName()
            {
                return "Test Name";
            }
        }

        public enum EmployeeType 
        {
            FullTime = 1,
            PartTime = 2
        }
    }


    public static class Test
    {
        public static void TestMethod1()
        {

        }

        public static void TestMethod2()
        {

        }
        public static void TestMethod3()
        {

        }
        public static void TestMethod4()
        {

        }
    }
}
