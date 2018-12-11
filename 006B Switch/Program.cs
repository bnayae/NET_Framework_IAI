using System;
using System.Collections.Generic;
using System.Text;

namespace _004_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Exe(ConsoleColor.Black);
        }

        private static void Exe(ConsoleColor c)
        {
            switch (c)
            {
                case ConsoleColor.Black:
                    Console.WriteLine("B");
                    goto case ConsoleColor.White;
                case ConsoleColor.White:
                    Console.WriteLine("W");
                    break;
                case ConsoleColor.DarkBlue:
                case ConsoleColor.DarkGreen:
                case ConsoleColor.DarkCyan:
                    Console.WriteLine("Other");
                    break;
                case ConsoleColor.DarkRed:
                    break;
                case ConsoleColor.DarkMagenta:
                    break;
                case ConsoleColor.DarkYellow:
                    break;
                case ConsoleColor.Gray:
                    break;
                case ConsoleColor.DarkGray:
                    break;
                case ConsoleColor.Blue:
                    break;
                case ConsoleColor.Green:
                    break;
                case ConsoleColor.Cyan:
                    break;
                case ConsoleColor.Red:
                    break;
                case ConsoleColor.Magenta:
                    break;
                case ConsoleColor.Yellow:
                    break;
                default:
                    break;
            }
        }
    }
}
