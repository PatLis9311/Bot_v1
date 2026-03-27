using Bot_v1.Commands;
using Bot_v1.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bot_v1.Test
{
    public class TaskTests
    {
        [Fact]
        public void AddTaskCommand_Should_Add_Task()
        {
            var bot = new BotEngine();
            var command = new AddTaskCommand();

            Console.SetIn(new StringReader("Test"));

            command.Execute(bot);

            Assert.Single(bot.Tasks);
        }
    }
}
