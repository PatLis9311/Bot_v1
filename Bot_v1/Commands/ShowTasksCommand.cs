using System;
using System.Collections.Generic;
using System.Text;

using Bot_v1.Core;

namespace Bot_v1.Commands
{
    public class ShowTasksCommand : IBotCommand
    {
        public string Name => "tasks";
        public void Execute(BotEngine bot)
        {
            if (bot.Tasks.Count == 0)
            {
                Console.WriteLine("Brak zadań");
                return;
            }
            for (int i = 0; i < bot.Tasks.Count; i++)
            {
                Console.WriteLine($"{i}. {bot.Tasks[i].Title}");
            }
        }
    }
}