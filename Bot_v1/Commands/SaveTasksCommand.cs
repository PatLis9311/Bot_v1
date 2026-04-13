using System;
using System.Collections.Generic;
using System.Text;
using Bot_v1.Core;
using Newtonsoft.Json;

namespace Bot_v1.Commands
{
    public class SaveTasksCommand : IBotCommand
    {
        public string Name => "save";
        public void Execute (BotEngine bot)
        {
            string json = JsonConvert.SerializeObject (bot.Tasks, Formatting.Indented);
            File.WriteAllText("tasks.json", json);

            Console.WriteLine("Zapisano zadania!");
        }
    }
}
