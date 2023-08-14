//using System;

//namespace ValueTypeParameter
//{
//    class Sample
//    {
//        static void Main()
//        {
//            var class1 = new Class1();
//            int result1 = class1.SumAndMinus(4 , 2);

//            Console.WriteLine("Result = {0} ", result1);

//            Console.ReadKey();
//        }
//    }

//    //Child class at other assembly
//    public class Class1
//    {
//        public int SumAndMinus(int x, in int y)
//        {
//            x = 10;
//            y = 20;

//            return x + y;
//        }
//    }
//}

