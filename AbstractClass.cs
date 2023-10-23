using System;
abstract class Base
{
    public void fun()
    {
        Console.WriteLine("Inside fun method...");
    }
    public void gun()
    {
        Console.WriteLine("Inside gun method...");
    }
    public abstract void sun();
}
class Derived:Base
{
    public void mun()
    {
        Console.WriteLine("Inside mun method...");
    }
    public override void sun()
    {
        Console.WriteLine("Inside sun method...");
    }
}
class AbstractClassDemo
{
    public static void Main(String[] arsg)
    {
        Derived obj=new Derived();
        
        obj.fun();
        obj.gun();
        obj.sun();
    }
}