using System;
class Base
{
    public int iNo1;
    public int iNo2;
    
    public Base(int X,int Y)
    {
        this.iNo1=X;
        this.iNo2=Y;
        
        Console.WriteLine("Inside Base parameterized constructor..");
    }
    public void fun()
    {
        Console.WriteLine("Inside base fun..");
    }
}
class Derived: Base
{
    public int A,B;
    
    public Derived(int iNo1,int iNo2):base(iNo1,iNo2)
    {
        Console.WriteLine("Inside Derived parameterized constructor..");
        this.A=iNo1;
        this.B=iNo2;
    }
    
    public void gun()
    {
        base.fun();
        Console.WriteLine("Value of iNo1:"+base.iNo1);
        Console.WriteLine("Value of iNo2:"+base.iNo2);
        Console.WriteLine("Inside gun..");
    }
}
class BaseDemo
{
    public static void Main(String[] args)
    {
        Derived obj=new Derived(10,20);
        obj.gun();
    }
}