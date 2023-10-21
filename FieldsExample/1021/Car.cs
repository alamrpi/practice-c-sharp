using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsExample._1021
{
    public struct Car 
    {
        public int _id;
        public string _name;
     

        public Car(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public Car(string name)
        {
            _id = -1;
            _name = name;
        }

    }
}
