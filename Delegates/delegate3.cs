using System;
public delegate void Del(string message);
public static class MethodClass
{
    public static void Method1(string message) 
    {
        System.Console.WriteLine(message);
    }
    public static void Method2(string message)
    {
        System.Console.WriteLine(message);
    }
}
class TestingDelegate
{
 // Create a method for a delegate.
    public static void DelegateMethod(string message)
    {
        System.Console.WriteLine(message);
    }
    public static void Main(string[] Agrs)
    {
        //Del handler = new Del(DelegateMethod);
        Del handler = DelegateMethod;
        
        Del d1 = MethodClass.Method1;
        Del d2 = MethodClass.Method2;
        Del d3 = DelegateMethod;
        //var d4 = new Del(DelegateMethod);
        //Both types of assignment are valid.
        Del allMethodsDelegate = d1 + d2 +d3;
        //allMethodsDelegate += d3;
        // calling 3 
        allMethodsDelegate("Multicasting");
        // removing method from delegate
        allMethodsDelegate-=d3;
        Console.WriteLine("After removing d2");
        allMethodsDelegate("After downcasting");

       //int invocationCount = allMethodsDelegate.GetInvocationList().GetLength(0);
        //handler("Here's the count of method: "+invocationCount);

        Console.ReadKey();
    }
}