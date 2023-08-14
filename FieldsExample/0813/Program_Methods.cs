//using System;

//class Sample
//{ 
//    static void Main()
//    {
//        var OtherClass2 = new OtherClass2();
//        Console.WriteLine(OtherClass2.value);

//        int testValue = 4;

//        var product = new InternationalProduct();
//        //product.Method1(OtherClass2);

//        Console.WriteLine(testValue);

//        product.Method2(testValue);

//        Console.WriteLine(testValue);

//        //Console.WriteLine(OtherClass2.value);

//        System.Console.ReadKey();
//    }
//}

////Child class at other assembly
//public class InternationalProduct
//{
//   private int _value;
//   private static int _value1;

//    public InternationalProduct()
//    {
//        _value = 1;
//        _value1 = 2;
//    }
//    public void Method1(OtherClass2 otherClass)
//    {
//        otherClass.value = 5;
//    }

//    public void Method2(int value)
//    {
//        value = 8;
//    }


//    public int Sum(int x, int y)
//    {
//        return x + y;
//    }

//}


//public class OtherClass2
//{
//    public int value;
//    public OtherClass2()
//    {
//        value = 2;
//    }
//}
