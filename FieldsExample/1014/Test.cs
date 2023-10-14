using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample._1014
{
    public class Test : ITest1, ITest2
    {
        void ITest1.Display()
        {
            throw new NotImplementedException();
        }
        void ITest2.Display()
        {
            throw new NotImplementedException();
        }
    }
}
