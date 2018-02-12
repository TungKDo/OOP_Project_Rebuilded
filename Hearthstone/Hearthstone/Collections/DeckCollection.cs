using Hearthstone.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Collections
{
    public class DeckCollection : IDeckCollection
    {
        //single instance 

        private readonly IDictionary<string, Deck> myDecks;

        public DeckCollection()
        {
            this.myDecks = new Dictionary<string, Deck>();
        }

        public IDictionary<string, Deck> MyDeck
        {
            get
            {
                return new Dictionary<string, Deck>(this.myDecks);
            }
        }

        public void CreateDeck(string deckName)
        {
            myDecks.Add(deckName, new Deck());
        }

        public void RemoveDeck(string deckName)
        {
            myDecks.Remove(deckName);
        }
    }
}
