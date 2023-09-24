using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Child
    {
        public void Display()
        {
            var parent = new Parent();
           Console.WriteLine(parent._name);
        }

    }
}
