using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Module_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0} ", arr[i,j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int value;

            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    for (int k = j + 1; k <= arr.GetUpperBound(1); k++)
                    {
                        if (arr[i,j] > arr[i,k])
                        {
                            value = arr[i,k];
                            arr[i,k] = arr[i,j];
                            arr[i,j] = value;
                        }
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}