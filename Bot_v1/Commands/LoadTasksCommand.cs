using System;
using System.Collections.Generic;
using System.Text;
using Bot_v1.Core;
using Bot_v1.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Bot_v1.Commands
{
    public class LoadTasksCommand : IBotCommand
    {
        public string Name => "load";
        public void Execute(BotEngine bot)
        {
            if (!File.Exists("tasks.json"))
            {
                Console.WriteLine("Brak pliku!");
                return;
            }
            string json = File.ReadAllText("task.json");

            var tasks = JsonConvert.DeserializeObject<List<TaskItem>>(json);

            if (tasks != null)
            {
                bot.Tasks = tasks;
                Console.WriteLine("Wczytano zadania");
            }
        }
    }
    
    
}
