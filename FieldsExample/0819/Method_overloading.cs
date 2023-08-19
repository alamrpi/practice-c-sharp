//using System;

//namespace ValueTypeParameter
//{
//    class Sample
//    {
//        static void Main()
//        {
//            ParentClass class1 = new ParentClass();
//            class1.DisplayName();
//            Console.ReadKey();
//        }
//    }

//    //Child class at other assembly
//    public class ParentClass
//    {

//        public void DisplayName()
//        {
//            Console.WriteLine("Test");
//        }

//        public void DisplayName(string name)
//        {
//            Console.WriteLine(name);
//        }

//        public void DisplayName(int roll, string name)
//        {
//            Console.WriteLine($"{roll} {name}");
//        }
//        public string DisplayName(int roll, string name, int h)
//        {
//            return $"{name} {roll}";
//        }
//    }

//    public class ChildClass : ParentClass
//    {
//        public void DisplayName(int roll, string name, string reg)
//        {
//            Console.WriteLine($"{roll} {name} 2");
//        }
//    }
//}

