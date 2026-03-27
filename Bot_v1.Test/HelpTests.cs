using System;
using Xunit;
using System.Collections.Generic;
using System.Text;
using Bot_v1.Core;
using Bot_v1.Commands;

namespace Bot_v1.Test
{
   public class HelpTests
    {
        [Fact]
        public void HelpCommand_Should_List_Commands()
        {
            var bot = new BotEngine();

            bot.RegisterCommand(new HelpCommand());
            bot.RegisterCommand(new ExitCommand());

            var command = new HelpCommand();

            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                command.Execute(bot);

                var output = sw.ToString();

               
                Assert.Contains("help", output);
            }
        }
    }
}
