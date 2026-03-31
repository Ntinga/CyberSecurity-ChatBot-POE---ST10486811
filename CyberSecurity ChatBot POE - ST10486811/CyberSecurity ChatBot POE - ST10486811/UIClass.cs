using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity_ChatBot_POE___ST10486811
{
    internal class UIClass
    {
        public static void displayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@"
                            + "@  ____                       _ _         @"
                            + "@ / ___|  ___  ___ _   _ _ __(_) |_ _   _ @"
                            + "@ \___  / _ \/ __| | | | '__| | __| | | |@"
                            + "@  ___) | ___/\(__| |_| | |  | | |_| |_| |@"
                            + "@ |____/ \___| \__|\__,_|_|  |_|\__|\__, |@"
                            + "@                                   |___/ @"
                            + "@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Console.WriteLine("Welcome!");
            Console.ResetColor();
        }
    }
}
