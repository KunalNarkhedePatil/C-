using System;

class Base
{
    public int X,Y;
    
    public Base()
    {
        Console.WriteLine("Inside Base Constructor...");
        X=10;
        Y=20;
    }
    ~Base()
    {
        Console.WriteLine("Inside Base destructor...");
    }
    public void fun()
    {
        Console.WriteLine("Inside Base fun");
    }
}
class Derived : Base
{
    int A,B;
    
    public Derived()
    {
        Console.WriteLine("Inside Derived Constructor...");
    }
    ~Derived()
    {
        Console.WriteLine("Inside Derived Destructor...");
    }
    public void gun()
    {
        Console.WriteLine("Inside Derived gun");
    }
}
class DerivedX: Derived
{
    public int P,Q;
    
    public DerivedX()
    {
        Console.WriteLine("Inside DerivedX Constructor...");
    }
    ~DerivedX()
    {
        Console.WriteLine("Inside DerivedX Destructor...");
    }
    public void mun()
    {
        Console.WriteLine("Inside DerivedX mun");
    }
}
class MultiLevel
{
    public static void Main(String[] args)
    {
        DerivedX obj=new DerivedX();
        obj.fun();
        obj.gun();
        obj.mun();
    }
}