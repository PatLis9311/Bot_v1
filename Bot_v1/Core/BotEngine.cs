using System;
using System.Collections.Generic;
using System.Text;

using Bot_v1.Models;

namespace Bot_v1.Core
{
    public class BotEngine
    {
        public User User { get; set; }
        public List<TaskItem> Tasks { get; set; }

        private List<IBotCommand> _commands;
        private bool _isRunning;

        public BotEngine()
        {
            User = new User();
            Tasks = new List<TaskItem>();
            _commands = new List<IBotCommand>();
            _isRunning = true;
        }

        public void RegisterCommand(IBotCommand command)
        {
            _commands.Add(command);
        }

        public void Start()
        {
            Console.WriteLine("Bot v2");
            while (_isRunning)
            {
                Console.Write("> ");
                string input = Console.ReadLine() ?? "";

                ExecuteCommand(input);
            }
        }

        private void ExecuteCommand(string input)
        {
            foreach (var command in _commands)
            {
                if (command.Name == input)
                {
                    command.Execute(this);
                    return;

                }
            }

            Console.WriteLine("Nieznana komenda");
        }

        public void Stop()
        {
            _isRunning = false;
        }
        public List<IBotCommand> GetCommands()
        {
            return _commands;
        }
    }
}
