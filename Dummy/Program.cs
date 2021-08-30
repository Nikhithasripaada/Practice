using System;
namespace Dummy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 10, b = 2;
            bool c = true | false;
            Console.WriteLine(c = a > b & b < a);
            float f = 5.6f;
            Console.WriteLine(f);
            double d = 5d;
            Console.WriteLine(d);
            //implicit typecasting
            int n = 6;
            double p = n;
            Console.WriteLine(n);
            Console.WriteLine(p);
            //explicit typecasting
            double x = 9.78;
            int y = (int)x;
            Console.WriteLine(x);
            Console.WriteLine(y);
            //other typecasting methods
            int myInt = 10;
            double myDouble = 7.25;
            bool myBool = true;
            Console.WriteLine(Convert.ToString(myInt));
            Console.WriteLine(Convert.ToDouble(myInt));
            Console.WriteLine(Convert.ToInt32(myDouble));
            Console.WriteLine(Convert.ToString(myBool));
            //strings
            string firstname = "nikhitha",
                lastname = "sripada";
            Console.WriteLine(firstname + lastname);
            Console.WriteLine(+firstname.Length);
            Console.WriteLine(firstname.ToUpper());
            Console.WriteLine(firstname.ToLower());
        }
    }
}
    

