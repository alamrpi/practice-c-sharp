using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary1
{
    public class Parent
    {
         internal string _name = "Parent";

        public void Display()
        {
            Console.WriteLine(_name);
        }
    }
}
