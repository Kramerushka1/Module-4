using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Module_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            (string Name, string Type, double Age, int NameCount) Pet;

            Console.Write("Укажите имя питомца: ");
            Pet.Name = Console.ReadLine();
            Console.Write("Укажите тип питомца: ");
            Pet.Type = Console.ReadLine();
            Console.Write("Укажите возраст питомца: ");
            Pet.Age = double.Parse(Console.ReadLine());
            Pet.NameCount = Pet.Name.Length;
            
            Console.WriteLine();

            Console.WriteLine("Имя питомца: {0}", Pet.Name);
            Console.WriteLine("Тип питомца: {0}", Pet.Type);
            Console.WriteLine("Возраст питомца: {0}", Pet.Age);
            Console.WriteLine("Длина имени питомца: {0}", Pet.NameCount);
        }
    }
}