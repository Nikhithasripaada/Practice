using System;
using System.Text;
using System.Collections;
namespace string_builder
{ 
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Haiiii", 10);
            //iteration
            for (int i = 0; i < sb.Length; i++)
                Console.Write(sb[i]);
            //retrieve whole string
            var greet = sb.ToString();
            Console.WriteLine(greet);
            //appendline
            sb.Append("Hello ");
            sb.AppendLine("Welcome!");
            sb.AppendLine("Hiiiii");
            Console.WriteLine(sb);
            //appendformat
            StringBuilder sbAmout = new StringBuilder("the total amount is ");
            sbAmout.AppendFormat("{0:C} ",10);
            Console.WriteLine(sbAmout);
            //insert
            sb.Insert(6, "warangal");
            Console.WriteLine(sb);
            //remove
            sb.Remove(2,3);
            Console.WriteLine(sb);
            //replace
            sb.Replace("warangal", "wgl");
            Console.WriteLine(sb);

            // boxing
            int j = 30;
            object o = j;
            Console.WriteLine(j);
            ArrayList list = new ArrayList();
            list.Add(20); 
            list.Add("Bill");
            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);

            //unboxing
            j = (int)o;
            Console.WriteLine(j);
            //(to unbox objects to its original datatype first need to unbox then typecast,if not so runtime error araises)

           // double d = (double)o;(exception araised)
            double d = (double)(int)o;
            Console.WriteLine(d);
            //Boxing and unboxing can degrade the performance. So,need to avoid using it. Using generics to avoid boxing and unboxing. For example, use List instead of ArrayList.
       
        }
    }
}
