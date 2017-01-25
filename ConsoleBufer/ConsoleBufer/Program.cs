using System;
using System.Threading;

namespace ConsoleBufer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor[] colors = {ConsoleColor.Black, ConsoleColor.Cyan, ConsoleColor.DarkCyan, ConsoleColor.DarkGreen,
            ConsoleColor.DarkRed, ConsoleColor.Magenta, ConsoleColor.Yellow};

                foreach (ConsoleColor color in colors)
            {
                Console.CursorLeft = (Console.BufferWidth - color.ToString().Length) / 2;
                Console.CursorTop = 10;
                Console.ForegroundColor = color;
                Console.WriteLine(color);
                Thread.Sleep(800);
                Console.Clear();
            }
        }
    }
}
