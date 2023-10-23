using System;

class ExceptionDemo
{
    public static void Main(String[] args)
    {
         try  
        {  
            int a = 10;  
            int b = 0;  
            int x = a / b;  
        }  
        catch(ArithmeticException e)
        {
             Console.WriteLine(e); 
        }
        catch(IndexOutOfRangeException e)
        {
            Console.WriteLine(e);
        }
        catch (Exception e) 
        {
            Console.WriteLine(e); 
            
        }  
 
    }
}