using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurity_ChatBot_POE___ST10486811
{
    internal class ChatBotClass
    {
        public string UserName { get; set; }

        public void playVoiceMessage()
        {
            try
            {
                using (SoundPlayer player = new SoundPlayer(""))
                {
                    player.PlaySync();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("System Note: Welcome audio not found.");
            }
        }

        public void Start()
        {
            UIClass.typeMessage("Assistant: Hello! Please enter your name to begin.");
            Console.Write("You: ");
            UserName = Console.ReadLine();

            if (string.IsNullOrEmpty(UserName))
            {
                UserName = "User";
            }

            UIClass.typeMessage($"Assistant: Welcome, {UserName}! I am your Cybersecurity Awareness Bot.", ConsoleColor.Green);
            UIClass.typeMessage("I'm here to help you stay safe online. How can I assist you today?");

            bool running = true;
            while (running)
            {
                Console.Write($"\n{UserName}: ");
                string input = Console.ReadLine()?.ToLower().Trim();

                if (string.IsNullOrEmpty(input))
                {
                    UIClass.typeMessage("Assistant: I didn't quite catch that. Could you rephrase?", ConsoleColor.Yellow);
                    continue;
                }

                if (input.Contains("exit") || input.Contains("bye"))
                {
                    UIClass.typeMessage($"Assistant: Stay safe out there, {UserName}! Goodbye.");
                    running = false;
                }
                else
                {
                    ProcessInput(input);
                }
            }
        }

        private void ProcessInput(string input)
        {
            if (input.Contains("purpose"))
            {
                UIClass.typeMessage("Assistant: My purpose is to educate South African citizens on identifying cyber threats like phishing and identity theft.");
            }
            else if (input.Contains("password"))
            {
                UIClass.typeMessage("Assistant: Safe practices include using long, complex passwords and enabling Two-Factor Authentication (2FA).");
            }
            else if (input.Contains("phishing"))
            {
                UIClass.typeMessage("Assistant: Phishing is when attackers use fake emails or links to steal your data. Always check the sender's address!");
            }
            else if (input.Contains("browser"))
            {
                UIClass.typeMessage("Assistant: Safe browsing means checking for 'https://' and avoiding suspicious pop-ups or unknown downloads.");
            }
            else if (input.Contains("how are you"))
            {
                UIClass.typeMessage("Assistant: I'm functioning perfectly! Ready to help you protect your data.");
            }
            else
            {
                UIClass.typeMessage("Assistant: I'm not sure how to answer that yet. Ask me about 'passwords', 'phishing', or my 'purpose'.", ConsoleColor.Yellow);
            }
        }
    }
}
