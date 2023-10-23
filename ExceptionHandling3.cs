//user defined exception
using System;
class AgeInvalid:Exception
{
    public AgeInvalid(String str):base(str)
    {
        
    }
}
class ExceptionDemo4
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter the age");
        int age=Convert.ToInt32(Console.ReadLine());
        try
        {
            if(age<18)
            {
                throw new AgeInvalid("Age is less than 18");
            }
            else
            {
                Console.WriteLine("You are eligible to vote.");
            }
        }
        catch(AgeInvalid obj)
        {
            Console.WriteLine("Exception occured:"+obj);
        }
    }
}