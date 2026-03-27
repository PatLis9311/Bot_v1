using System;
using System.Collections.Generic;
using System.Text;
using Bot_v1.Core;
using Bot_v1.Commands;

namespace Bot_v1.Test
{
    public class ExitTests
    {
        [Fact]
        public void ExitCommand_Should_Stop_Bot()
        {
            var bot = new BotEngine();
            var command = new ExitCommand();

            command.Execute(bot);

            Assert.False(bot.IsRunning);
        }
    }
}
