using System;

class Base
{
    public int iNo1,iNo2;
    
    public Base()
    {
        Console.WriteLine("Inside Base Constructor...");
        this.iNo1=10;
        this.iNo2=20;
    }
    ~Base()
    {
        Console.WriteLine("Inside Base Destructor....");
    }
  
    public void fun()
    {
        Console.WriteLine("Inside Base fun");
    }
    
}
class Derived:Base
{
    public int X,Y;
    
    public Derived()
    {
        Console.WriteLine("Inside Derived Constructor...");
        X=0;
        Y=0;
    }
      ~Derived()
    {
        Console.WriteLine("Inside Derived Destructor....");
    }
    public void gun()
    {
        Console.WriteLine("Inside Derived gun....");
    }
}
class Demo
{
    public static void Main(String[] args)
    {
       Derived obj=new Derived();
       obj.fun();
       obj.gun();
    }
}