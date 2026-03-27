using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Bot_v1.Core;
using Bot_v1.Commands;

namespace Bot_v1.Test
{
    public class BotEngineTests
    {
        [Fact]
        public void Bot_Should_Start_With_Empty_Task_List()
        {
            var bot = new BotEngine();

            Assert.Empty(bot.Tasks);

        }
    }
}
