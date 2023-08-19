//using System;

//namespace ValueTypeParameter
//{
//    class Sample
//    {
//        static void Main()
//        {
//            ParentClass class1 = new ParentClass();
//            Console.WriteLine(class1.DisplayName(20, "Alam"));
//            Console.ReadKey();
//        }
//    }

//    //Child class at other assembly
//    public class ParentClass
//    {
//        public virtual string DisplayName(int roll, string name)
//        {
//            return $"{name} {roll}";
//        }
//    }

//    public class ChildClass : ParentClass
//    {
//        public override string DisplayName(int roll, string name)
//        {
//            return $"{name} {roll} from child";
//        }

//    }
//}

