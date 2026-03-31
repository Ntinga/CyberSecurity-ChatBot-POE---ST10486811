using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CyberSecurity_ChatBot_POE___ST10486811
{
    internal class UIClass
    {
        public static void displayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("@  ____                       _ _         @");
            Console.WriteLine("@ / ___|  ___  ___ _   _ _ __(_) |_ _   _ @");
            Console.WriteLine("@ |___   / _ |/ __| | | | '__| | __| | | |@");
            Console.WriteLine("@  ___) | ___/|(__| |_| | |  | | |_| |_| |@");
            Console.WriteLine("@ |____/ |___| |__|___,_|_|  |_||__||__, |@");
            Console.WriteLine("@                                   |___/ @");
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("Welcome!");
            Console.ResetColor();
        }

        public static void typeMessage(string message, ConsoleColor color = ConsoleColor.DarkBlue)
        {
            Console.ForegroundColor = color;
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(10);
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
