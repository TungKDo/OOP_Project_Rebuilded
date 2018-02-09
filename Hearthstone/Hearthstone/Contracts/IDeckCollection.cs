using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Contracts
{
    public interface IDeckCollection
    {
        void CreateDeck(string deckName);
        void RemoveDeck(string deckName);

    }
}
