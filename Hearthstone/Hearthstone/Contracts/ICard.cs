using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Contracts
{
    interface ICard
    {
        string Name { get; set; }
        int ManaCost { get; set; }
    }
}
