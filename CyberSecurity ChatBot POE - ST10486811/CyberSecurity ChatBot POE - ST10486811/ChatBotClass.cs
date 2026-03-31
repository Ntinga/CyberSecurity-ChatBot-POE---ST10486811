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


    }
}
