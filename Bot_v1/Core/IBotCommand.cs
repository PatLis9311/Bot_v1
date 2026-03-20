using System;
using System.Collections.Generic;
using System.Text;

using Bot_v1.Core;

namespace Bot_v1.Core
{
    public interface IBotCommand
    {
        string Name { get; }


        void Execute(BotEngine bot);

    }

 }
