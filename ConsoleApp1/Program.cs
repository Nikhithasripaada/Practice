using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //single dimensional array
            int[] arr = new int[5];
            arr[0] = 10;
            arr[2] = 20;
            arr[4] = 30;
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Sum());
            Console.WriteLine(arr[0]);
            string[] vijay = { "theri", "thupaki", "snehithudu" };
            Console.WriteLine(vijay[2]);
            Console.WriteLine(+vijay.Length);
            vijay = new string[] { "master" };
            Console.WriteLine(vijay[0]);
            Array.Sort(vijay);
            foreach (string n in vijay)
            {
                Console.WriteLine(n);
            }
            //multi dimensional
            int[,] arr2 = new int[3, 3];
            arr2[0, 1] = 10;
            arr2[1, 2] = 20;
            arr2[2, 0] = 30;
            Console.WriteLine(arr2[1, 2]);
            //traversal  
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine(arr3[0,1]);
            int[][] arr4 = new int[2][];
            arr4[0] = new int[4] { 11, 21, 56, 78 };
            arr4[1] = new int[6] { 42, 61, 37, 41, 59, 63 };
            // Traverse array elements  
            for (int i = 0; i < arr4.Length; i++)
            {
                for (int j = 0; j < arr4[i].Length; j++)
                {
                    System.Console.Write(arr4[i][j] + " ");
                }
                System.Console.WriteLine();
            }
        }
    }
}
