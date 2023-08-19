//using System;

//namespace ValueTypeParameter
//{
//    class Sample
//    {
//        static void Main()
//        {
//            TestClass class1 = new TestClass();
//            Console.WriteLine(class1.DisplayName(20, "Alam"));

//            Console.ReadKey();
//        }
//    }

//    //Child class at other assembly
//    public class TestClass
//    {
//        public string DisplayName(int roll, string name)
//        {
//            //Local function 
//            void TestMethod()
//            {
//                Console.WriteLine("Local Method Calling");
//            }

//            TestMethod();
//            return $"{name} {roll}";
//        }

//        //public string TestLocalMethod()
//        //{
//        //    TestMethod();
//        //}
//    }
//}

