﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFinalBattle
{
    // An interface to represent if it's a human player
    public interface IPlayer
    {
        IAction ChooseAction(Game game, Character character)
        {
            return new SkipAction();
        }
    }
}
