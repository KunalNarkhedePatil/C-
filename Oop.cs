using System;
public class Test
{
    public int iNo1;
    public int iNo2;
    
   public Test()
    {
        iNo1=0;
        iNo2=0;
         Console.WriteLine("Inside the Const");
    }
    public void fun()
    {
        Console.WriteLine("Inside the fun..");
    }
}
class Demo
{
    public static void Main(String[] arsg)
    {
        Test obj=new Test();
        obj.fun();
    }
}