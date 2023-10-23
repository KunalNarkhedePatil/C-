using System;

class Base
{
    public virtual void fun()
    {
        Console.WriteLine("Inside Base fun...");
    }
}
class Derived :Base
{
    public sealed override void fun()
    {
        Console.WriteLine("Inside Derived fun...");
    }
}
class DerivedX:Derived
{
    public  override void fun()
    {
        Console.WriteLine("Inside DerivedX fun...");
    }
}
class SealedMethodDemo
{
    public static void Main(String[] arsg)
    {
        DerivedX dobj=new DerivedX();
        
        dobj.fun();
    }
}