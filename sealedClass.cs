using System;

sealed class Base
{
    public int iNo1,iNo2;
    
    public Base()
    {
        Console.WriteLine("Inside Base Dafault Constructor..");
        this.iNo1=0;
        this.iNo2=0;
    }
    ~Base()
    {
        Console.WriteLine("Inside Base Destructor...");
    }
    public void fun()
    {
        Console.WriteLine("Inside the fun....");
    }
}
class Derived:Base
{
    public int X,Y;
    
    public Derived()
    {
        Console.WriteLine("Inside Derived Default Constructor..");
    }
    ~Derived()
    {
        Console.WriteLine("Inside Derived Destructor...");
    }
    public void gun()
    {
         Console.WriteLine("Inside the fun....");
    }
}
class SealedDemo
{
    public static void Main(String[] args)
    {
        Derived dobj=new Derived();
        
        dobj.fun();
        dobj.gun();
    }
}