using System;

namespace Board
{
    class Program
    {
        delegate void Message(string message);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Message msg;
            msg = ShowConsole;

        }
        static void ShowConsole(string msg)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}
