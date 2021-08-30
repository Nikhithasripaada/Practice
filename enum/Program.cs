using System;
public class EnumExample
{
    public enum Season { WINTER, SPRING, SUMMER, FALL }
    enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

    public static void Main()
    {
        int x = (int)Season.WINTER;
        int y = (int)Season.SUMMER;
        Console.WriteLine("WINTER = {0}", x);
        Console.WriteLine("SUMMER = {0}", y);
        int a = (int)Days.Sun;
        int b = (int)Days.Mon;
        int c = (int)Days.Sat;
        Console.WriteLine("Sun = {0}", a);
        Console.WriteLine("Mon = {0}", b);
        Console.WriteLine("Sat = {0}", c);
    }
}