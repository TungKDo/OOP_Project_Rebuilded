using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Engine
{
    public static class Constants
    {
        public static string MainMenuOptions => "\n1. New Game\n2. Deck Collection\n3. Credits\n4. Exit";
        public static string DeckCollectionMenu => "\n1. Create Deck\n2. Delete Deck\n3. Add cards to an existing Deck\n4. Remove cards to an existing Deck\n5. List all cards in a deck\n6. Back";
        public static string AskToEnterDeckName => "Please type in the deck name";
        public static string AskPlayerToSelectADeck => "Player {0} please choose your deck:";

    }
}
