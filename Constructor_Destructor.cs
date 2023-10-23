using System;
class Base
{
    int iNo1;
    int iNo2;
    
    public Base()
    {
        Console.WriteLine("Inside default constructor...");
    }
    ~Base()
    {
        Console.WriteLine("Inside the Destructor...");
    }
    public Base(int X,int Y)
    {
        Console.WriteLine("Inside parameterized constructor..");
    }
    public Base(Base b1)
    {
        Console.WriteLine("Inside copy constructor...");
    }
    static Base()
    {
        Console.WriteLine("Inside static constructor...");
    }
    //private Base()
    //{
      //  Console.WriteLine("Inside private constructor...");
    //}
}
class Demo
{
    public static void Main(String[] arsg)
    {
        Base obj=new Base();
        Base obj1=new Base(10,20);
        Base obj2=new Base(obj1);
        
    }
}