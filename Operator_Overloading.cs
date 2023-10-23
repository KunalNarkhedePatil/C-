using System;
class Demo
{
    public int iNo1;
    public Demo()
    {
       iNo1=0;
    }
    public static Demo operator +(Demo op1,Demo op2)
    {
       Demo obj3=new Demo();
       
       obj3.iNo1=op1.iNo1+op2.iNo1;
       
       return obj3;
    }
}
class OperatorOverloading
{
    public static void Main(String[] args)
    {
        Demo obj1=new Demo();
        Demo obj2=new Demo();
        
        obj1.iNo1=10;
        obj2.iNo1=20;
        
        Demo obj3=obj1+obj2;
        
        Console.WriteLine("Addition is "+obj3.iNo1);
    }
}