﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Contracts
{
    public interface ICard
    {
        string Name { get; }
        int ManaCost { get; }
    }
}
