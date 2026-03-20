using Bot_v1.Core;
using Bot_v1.Commands;

class Program
{
    static void Main(string[] args)
    {
        BotEngine bot = new BotEngine();

        bot.RegisterCommand(new HelpCommand());
        bot.RegisterCommand(new AddTaskCommand());
        bot.RegisterCommand(new ShowTasksCommand());
        bot.RegisterCommand(new ExitCommand());

        bot.Start();
    }
}