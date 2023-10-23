using System;
class Base
{
    public void fun()
    {
        Console.WriteLine("Inside base fun....");
    }
    public virtual void gun()
    {
        Console.WriteLine("Inside base gun....");
    }
}
class Derived:Base
{
    public void mun()
    {
        Console.WriteLine("Inside Derived mun....");
    }
    public override void gun()
    {
        Console.WriteLine("Inside Derived fun....");
    }
}
class MethodOverridingDemo
{
    public static void Main(String[] arsg)
    {
        Base bp=new Derived();
        bp.fun();
        bp.gun();
      //  bp.mun();
    }
}