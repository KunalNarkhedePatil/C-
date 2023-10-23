using System;
interface Base
{
    public void fun();
    public void gun();
}
class Derived: Base
{
    public void fun()
    {
        Console.WriteLine("Inside fun...");
        
    }
    public void gun()
    {
        Console.WriteLine("Inside gun...");
    }
}
class InterfaceDemo
{
    public static void Main(String[] args)
    {
        Derived obj=new Derived();
        
        obj.fun();
        obj.gun();
    }
}