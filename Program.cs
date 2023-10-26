using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Module_4
{
    internal class Program
    {
        //Необходимо разработать методику анкетирования пользователей.
        //Требуется сохранять информацию:
        //об имени пользователя,
        //фамилии,
        //логине,
        //длине логина,
        //наличии/отсутствии у пользователя питомца,
        //возрасте пользователя,
        //трех любимых цветах пользователя.
        static void Main(string[] args)
        {
            (string Name, string Surname, string Login, int LoginCount, bool HasPet, int Age, string[] FavoriteColor) User;
            
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Введите имя: ");
                User.Name = Console.ReadLine();

                Console.Write("Введите фамилию: ");
                User.Surname = Console.ReadLine();

                Console.Write("Введите логин: ");
                User.Login = Console.ReadLine();
                User.LoginCount = User.Login.Length;

                Console.Write("Есть ли у вас животные? Да или Нет: ");
                if (Console.ReadLine() == "Да")
                {
                    User.HasPet = true;
                }
                else
                {
                    User.HasPet = false;
                }

                Console.Write("Введите возраст: ");
                User.Age = int.Parse(Console.ReadLine());

                User.FavoriteColor = new string[3];
                Console.WriteLine("Введите три любимых цвета:");
                for (int j = 0; j < User.FavoriteColor.Length; j++)
                {
                    User.FavoriteColor[j] = Console.ReadLine();
                }
                Console.WriteLine();
            }
        }
    }
}