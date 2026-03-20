using System;
using System.Collections.Generic;
using System.Text;
using Bot_v1.Core;
using Bot_v1.Models;

namespace Bot_v1.Commands
{
    public class AddTaskCommand : IBotCommand
    {
        public string Name => "addtask";
        public void Execute(BotEngine bot)
        {
            Console.Write("Podaj nazwę zadania: ");
            string title = Console.ReadLine();

            TaskItem task = new TaskItem
            {
                Title = title,
                IsCompleted = false
            };

            bot.Tasks.Add(task);

            Console.WriteLine("Dodano zadanie.");
        }
    }
}
