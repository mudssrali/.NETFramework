using System;
public delegate void Del(string message);
public delegate void DelCallback(int  param1, int param2, Del callback);
class TestingDelegate
{
 // Create a method for a delegate.
    public static void DelegateMethod(string message)
    {
        System.Console.WriteLine(message);
    }
    // Callback using delegate
    public static void MethodWithCallback(int param1, int param2, Del handler)
    {
        handler("The number is: " + (param1 + param2).ToString());
    }
    public static void Main(string[] Agrs)
    {
        //Del handler = new Del(DelegateMethod);
        Del handler = DelegateMethod;
        DelCallback chanlder = MethodWithCallback;
        handler("Pakistan is my land");
        //MethodWithCallback(45,31,handler);
        chanlder(45,31,handler);
        Console.ReadKey();
    }
}