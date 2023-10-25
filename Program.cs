using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Module_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            (string name, int age, string city) anketa;
            
            Console.Write("What is your name: ");
            anketa.name = Console.ReadLine();
            Console.Write("How old are you: ");
            anketa.age = int.Parse(Console.ReadLine());
            Console.Write("Where are you from: ");
            anketa.city = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Your name is {0}", anketa.name);
            Console.WriteLine("You are {0} years old", anketa.age);
            Console.WriteLine("You are from {0}", anketa.city);
        }
    }
}