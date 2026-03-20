using System;
using System.Collections.Generic;
using System.Text;

using Bot_v1.Core;
namespace Bot_v1.Commands

{
    public class HelpCommand : IBotCommand
    {
        public string Name => "help";
        public void Execute(BotEngine bot)
        {
            Console.WriteLine("Dostępne komendy: ");

            foreach (var cmd in bot.GetCommands())
            {
                Console.WriteLine("- " + cmd.Name);
            }
        }
    }
}