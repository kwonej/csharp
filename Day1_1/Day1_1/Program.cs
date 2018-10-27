using System;

class TypeCastExample1
{
    public static void Main()
    {
        //hort a = 10;
        //t b = a;

     int c = 50000;
        try
        {
            short d = checked((short)c);
            Console.WriteLine("Short : {0}", d);
        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }
    }
}