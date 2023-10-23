using System;


class ExceptionDemo
{
    public static void Main(String[] args)
    {
        int[] Arr={10,20,30,40,50};
        
        try
        {
            Console.WriteLine("Element is "+Arr[3]);
            //Console.WriteLine("Element is "+Arr[7]);
        }
        catch(IndexOutOfRangeException e)
        {
            Console.WriteLine("Exception occur:"+e);
        }
    }
}