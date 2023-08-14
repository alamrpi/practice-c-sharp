//using System;

//namespace ValueTypeParameter
//{
//    class Sample
//    {
//        static void Main()
//        {
//            var class1 = new Class1();
//            int result1 = class1.SumAndMinus();
//            result1 = 50;

//            Console.WriteLine("Result = {0} ", result1);

//            Console.ReadKey();
//        }
//    }

//    //Child class at other assembly
//    public class Class1
//    {
//        public int testValue = 40;
//        public ref int SumAndMinus()
//        {
//            return ref testValue;
//        }

//        public void Display()
//        {
//            Console.WriteLine(testValue);
//        }
//    }
//}

