using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //if loop
            if (15 > 10)
            {
                Console.WriteLine("15 is greater than 10");
                //if loop using variable
                int x = 10;
                int y = 18;
                if (x > y)
                {
                    Console.WriteLine("18 is greater than 10");
                }
                //if else loop
                else
                {
                    Console.WriteLine("Good evening.");
                }
                //else if
                int time = 22;
                if (time < 10)
                {
                    Console.WriteLine("Good morning.");
                }
                else if (time > 20)
                {
                    Console.WriteLine("Good day.");
                }
                //variable = (condition) ? expressionTrue :  expressionFalse;
                string result = (time < 18) ? "nice day." : "Good afternoon.";
                Console.WriteLine(result);
                //switch
                int i = 2;
                switch (i)
                {
                    case 1:
                        Console.WriteLine("True");
                        break;
                    case 2:
                        Console.WriteLine("False");
                        break;
                    case 3:
                        Console.WriteLine("undefined");
                        break;
                }
                //do while
                int i1 = 0;
                while(i1 <15)
                {
                    ++i1;
                    Console.WriteLine(i1);
                }

                //for loop
                for (int z = 5; z < 15;z++)
                {
                    //z = z.Replace(".", ".\n");
                    Console.WriteLine(z);
                }
                string[] vijay = { "theri", "thupaki", "snehithudu" };
                Console.WriteLine(vijay[2]);
                Console.WriteLine(+vijay.Length);
                foreach (string j in vijay)
                {
                    Console.WriteLine(j);
                }

                //break/continue
                int k;
                for (k = 0; k <= 10; k++)
                {
                    if (k == 5)
                        continue;
                    if (k == 8)
                        break;
                    Console.WriteLine("value is \n" + k);
                }
            Console.ReadLine();
            }
        }
    }
}
