﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Contracts
{
    public interface ICardFactory
    {
        ICard CreateCard(string cardToBeAdded);
    }
}
