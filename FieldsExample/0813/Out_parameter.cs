//using System;

//namespace ValueTypeParameter
//{
//    class Sample
//    {
//        static void Main()
//        {
//            int result;

//            var class1 = new Class1();
//            int result1 = class1.SumAndMinus(4 , 2, out result);

//            Console.WriteLine("Result = {0}, Result1 = {1} ", result, result1);

//            Console.ReadKey();
//        }
//    }

//    //Child class at other assembly
//    public class Class1
//    {
//        public int SumAndMinus(int x, int y, out int result)
//        {
//            result = x - y;
//            return x + y;
//        }
//    }
//}

