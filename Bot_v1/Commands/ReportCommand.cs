using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Bot_v1.Core;

namespace Bot_v1.Commands
{
   public class ReportCommand : IBotCommand
    {
        public string Name => "report";

        public void Execute(BotEngine bot)
        {
            var report = new
            {
                User = bot.User.Name,
                Date = DateTime.Now,
                Tasks = bot.Tasks
            };

            string json = JsonConvert.SerializeObject(report, Formatting.Indented);
            File.WriteAllText("report.json", json);
            Console.WriteLine("Raport zapisany");
        }
    }
}
