using System;
class Practice
{
    public int iNo1;
    public int iNo2;
    
    public Practice()
    {
        iNo1=0;
        iNo2=0;
    }
    
    public void fun(int iNo1,int iNo2)
    {
       Console.WriteLine("Inside Two int");
    }
    public void fun(int iNo1,int iNo2 ,int iNo3)
    {
       Console.WriteLine("Inside Three int"); 
    }
    public void fun(int iNo1 ,float fNo2)
    {
        Console.WriteLine("Inside one int , one float");
    }
    public void fun(float fNo1,int iNo2)
    {
        Console.WriteLine("Inside one float,one int");
    }
    public void fun(float fNo1,float fNo2)
    {
        Console.WriteLine("Inside Two flaot");
    }
    
}
class Demo
{
    public static void Main(String[] arsg)
    {
        Practice obj=new Practice();
        
        obj.fun(11,12);
        obj.fun(11,22,34);
        obj.fun(11.22f,11);
        obj.fun(11,33.44f);
        obj.fun(23.22f,45.66f);
    }
}