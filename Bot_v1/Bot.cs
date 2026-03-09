using System;
using System.Collections.Generic;




    class Bot
    {
        private User _user;
        private List<TaskItem> _tasks;
        private string[] _commands;
        private bool _isRunning;

        public Bot()
        {
            _user = new User();
            _tasks = new List<TaskItem>();

            _commands = new string[]
            {
                "help",
                "name",
                "whoami",
                "addtask",
                "tasks",
                "removetask",
                "time",
                "exit"
            };

            _isRunning = true;

        }

        public void Start()
        {
            ShowWelcomeMessage();
            Run();
        }

        private void Run()
        {
            while(_isRunning)
            {
                Console.Write(">");
                string input = Console.ReadLine();

                ProcessCommand(input);

            }
        }
        private void ShowWelcomeMessage()
        {
            Console.WriteLine("Witaj w BOT_v1");
            Console.WriteLine("Wpisz 'help' aby zobaczyć komendy");

        }
        private void ProcessCommand(string input)
        {
            switch (input)
            {
                case "help":
                    ShowHelp();
                    break;

                case "name":
                    SetUserName();
                    break;
                case "whoami":
                    ShowUserInfo();
                    break;

                case "addtask":
                    AddTask();
                    break;

                case "tasks":
                    ShowTasks();
                    break;

                case "removetask":
                    RemoveTask();
                    break;

                case "time":
                    ShowCurrentTime();
                    break;

                case "exit":
                    Exit();
                    break;

                default:
                    Console.WriteLine("Nie znam tej komendy");
                    break;



            }
        }
        private void ShowHelp()
        {
            Console.WriteLine("Dostępne komendy:");
            foreach (var command in _commands)
            {
                Console.WriteLine("- " + command); 
            }

        }
        private void SetUserName()
        {
            Console.WriteLine("Podaj swoje imię: ");
            _user.Name = Console.ReadLine();

            Console.WriteLine("Miło mi cię poznać" + _user.Name);

        }

        private void ShowUserInfo()
        {
            if (string.IsNullOrEmpty(_user.Name))
            {
                Console.WriteLine("Nie znam jeszcze twojego immienia.");
            }
            else
            {
                Console.WriteLine("Twoje imie to " + _user.Name);
            }
        }

        private void AddTask()
        {
            Console.Write("Podaj nazwę zadania");
            string title = Console.ReadLine();

            TaskItem task = new TaskItem();
            task.Title = title;
            task.IsCompleted = false;

            _tasks.Add(task);

            Console.WriteLine("Dodano zadanie");
        }
        private void ShowTasks()
        {
            if (_tasks.Count == 0)
            {
                Console.WriteLine("Ups brak zadań");
                return;
            }
            for (int i = 0; i < _tasks.Count; i++)
            {
                Console.WriteLine($"{i}. {_tasks[i].Title}");
            }
        }
        private void RemoveTask()
        {
            ShowTasks();

            Console.Write("Podaj numer zadania do usunięcia: ");
            String input = Console.ReadLine();

            if (int.TryParse(input, out int index))
            {
                if (index >= 0 && index < _tasks.Count)
                {
                    _tasks.RemoveAt(index);
                    Console.WriteLine("Zadanie usunięte.");
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy numer");
                }

            }
            else
            {
                Console.WriteLine("To nie jest liczba!");
            }
        }

        private void ShowCurrentTime()
        {
            Console.WriteLine("Aktualny czas: " + DateTime.Now);

        }

        private void Exit()
        {
            Console.WriteLine("Byebye");
            _isRunning = false;
        }
               
            
              

    }

