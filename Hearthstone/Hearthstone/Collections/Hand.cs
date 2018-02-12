using Hearthstone.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Collections
{
    public class Hand
    {
        private IList<ICard> cardsInHand;

        public Hand()
        {
            this.cardsInHand = new List<ICard>();
        }

        public void PrintHand()
        {
            foreach (var card in this.cardsInHand)
            {
                card.ToString(); 
            }
        }

        public IList<ICard> CardsInHand
        {
            get
            {
                return new List<ICard>(this.cardsInHand);
            }
            protected set
            {
                this.cardsInHand = value;
            }
        }

        public void Add(ICard card)
        {
            this.CardsInHand.Add(card);
        }

        public void Remove(ICard card)
        {
            this.CardsInHand.Remove(card);
        }
    }
}
