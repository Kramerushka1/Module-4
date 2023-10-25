using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Module_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var (name, age) = ("Виктор", 28);
            Console.WriteLine("Мое имя: {0}", name);
            Console.WriteLine("Мой возраст: {0}", age);

            Console.WriteLine();

            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);
        }
    }
}