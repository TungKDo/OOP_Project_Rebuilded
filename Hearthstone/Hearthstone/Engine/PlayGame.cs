using Hearthstone.Collections;
using Hearthstone.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Engine
{
    class PlayGame
    {
        private IDeckCollection deckCollection;
        public PlayGame(IDeckCollection deckCollection)
        {
            this.deckCollection = deckCollection;
        }

        public IPlayer CreatePlayers()
        {

        }
    }
}
