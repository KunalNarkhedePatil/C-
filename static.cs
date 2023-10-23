using System;

class Demo
{
    public int X;
    public static int Y;
    
    public Demo()
    {
         Console.WriteLine("Inside default constructor");
        this.X=10;
    }
    static Demo()
    {
        Console.WriteLine("Inside static constructor");
        Y=20;
    }
    
    public void fun()
    {
        Console.WriteLine("Inside non static fun..");
        Console.WriteLine("Value of X:"+this.X);
        Console.WriteLine("Value of Y:"+Demo.Y);
    }
    public static void gun()
    {
        Console.WriteLine("Inside static gun..");
        //Console.WriteLine("Value of X:"+this.X);
        Console.WriteLine("Value of Y:"+Demo.Y);
    }
}
class StaticDemo
{
    public static void Main(String[] args)
    {
        Demo obj=new Demo();
        obj.fun();
        Demo.gun();
        
        Console.WriteLine("Value of X:"+obj.X);
        Console.WriteLine("Value of Y:"+Demo.Y);
    }
}