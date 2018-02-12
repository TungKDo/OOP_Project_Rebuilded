using Hearthstone.Contracts;
using Hearthstone.Exceptions;
using System;
using System.Collections.Generic;

namespace Hearthstone.Collections
{
    public class Deck 
    {
        private IList<ICard> cards;

        public Deck()
        {
            this.cards = new List<ICard>();
        }

        public IList<ICard> Cards
        {
            get
            {
                return new List<ICard>(this.cards);
            }
            set //protected?
            {
                this.cards = value;
            }
        }

        public void Add(ICard card)
        {
            if(card == null)
            {
                throw new CardNullException("Card cannot be null.");
            }

            if (CheckIfListContainsCard(card))
            {
                Console.WriteLine("The list doesn't contains the card.");
                return;
            }

            this.cards.Add(card);
        }

        public void Remove(ICard card)
        {
            if (card == null)
            {
                throw new CardNullException("Card cannot be null.")
            }

            if (!CheckIfListContainsCard(card))
            {
                Console.WriteLine("The list doesn't contains the card.");
                return;
            }

            this.cards.Remove(card);
        }

        public void Shuffle()
        {
            IList<ICard> shuffledDeck = new List<ICard>();

            Random rnd = new Random();

            while (this.cards.Count > 0)
            {
                int r = rnd.Next(0, this.cards.Count);
                shuffledDeck.Add(this.cards[r]);
                this.cards.Remove(this.cards[r]);
            }
            this.cards = shuffledDeck;
        }
        
        public bool CheckIfListContainsCard(ICard card)
        {
            bool ifListContainsCard = true;

            if (!cards.Contains(card))
            {
                ifListContainsCard = false;
            }

            return ifListContainsCard;
        }
    }
}