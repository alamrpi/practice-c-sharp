using System.Runtime.InteropServices;

namespace FieldsExample._0903
{
    public class ConstructorExample
    {
        Singleton singleton = Singleton.GetInstance();
        Singleton singleton2 = Singleton.GetInstance();

    }


    public class Singleton
    {
        private static Singleton _singletone;
        private Singleton() { 

        }

        public static Singleton GetInstance()
        {
            if(_singletone == null)
            {
                _singletone = new Singleton();
            }
            return _singletone;
        }

    }
}
