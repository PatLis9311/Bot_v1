using System;
using System.Collections.Generic;
using System.Text;
using Bot_v1.Core;
using Bot_v1.Commands;
using Bot_v1.Models;

namespace Bot_v1.Test
{
    public class ShowTasksTests
    {
        [Fact]
        public void ShowTasks_Should_Display_Task()
        {
            var bot = new BotEngine();

            bot.Tasks.Add(new TaskItem { Title = "Test", IsCompleted = false });

            var command = new ShowTasksCommand();
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                command.Execute(bot);

                var output = sw.ToString();

                Assert.Contains("Test", output);
            }

        }
    }
}
