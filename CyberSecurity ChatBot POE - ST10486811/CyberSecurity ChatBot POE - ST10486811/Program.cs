using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity_ChatBot_POE___ST10486811
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CyberSecurity Awareness ChatBot";

            ChatBotClass bot = new ChatBotClass();

            bot.playVoiceMessage();

            UIClass.displayLogo();

            bot.Start();

            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();
        }
    }
}
