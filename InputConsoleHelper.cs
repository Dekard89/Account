using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ3
{
    public static class InputConsoleHelper
    {
        public static void PrintLine(string messege, ConsoleColor color)
        {
            Console.ForegroundColor= color;
            Console.Write(messege);
            Console.ResetColor();
        }

        public static string AccInput(string enter)
        {
            string str;

            PrintLine($"введите{enter}",ConsoleColor.Blue);
            str = Console.ReadLine();
            Console.WriteLine();
            return str;
        }
        public static void PrintMenu()
        {
            PrintLine("M a i n   M E N U", ConsoleColor.Blue);
            PrintLine("1. Войти в свой аккаунт", ConsoleColor.Blue);
            PrintLine("2. Создать новый аккаунт", ConsoleColor.Blue);
            PrintLine("3. Сменить пароль", ConsoleColor.Blue);
            PrintLine("0. Выход", ConsoleColor.Blue);
            
        }
       

    }
}
