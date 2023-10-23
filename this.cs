using System;

class Demo
{
   public int iNo;
   public Demo():this(10)
   {
       Console.WriteLine("Inside dafault constructor...");
   }
   public Demo(int iNo)
   {
       this.iNo=iNo;
       Console.WriteLine("Inside parameterized constructor..");
   }
   public void fun()
   {
       this.gun();
       Console.WriteLine("Inside fun...");
   }
   public void gun()
   {
       Console.WriteLine("Value of iNo1: "+this.iNo);
       Console.WriteLine("Inside gun...");
   }
}
class ThisDemo
{
    public static void Main(String[] args)
    {
        Demo obj=new Demo();
        obj.fun();
    }
}