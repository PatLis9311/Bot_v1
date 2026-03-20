using System;
using System.Collections.Generic;
using System.Text;

using Bot_v1.Core;

namespace Bot_v1.Commands
{
    public class ExitCommand : IBotCommand
    {
        public string Name => "exit";
        public void Execute(BotEngine bot)
        {
            Console.WriteLine("Do zobaczenia!");
            bot.Stop();
        }
    }


 }