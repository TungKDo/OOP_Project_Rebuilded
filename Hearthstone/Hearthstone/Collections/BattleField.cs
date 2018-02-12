using Hearthstone.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Collections
{
    public class BattleField
    {
        private IList<ICard> cardOnBattleField;

        public BattleField()
        {
            this.cardOnBattleField = new List<ICard>();
        }

        public IList<ICard> CardsOnBattleField
        {
            get
            {
                return new List<ICard>(this.cardOnBattleField);
            }
        }

        public void AddCardToBattleField(ICard card)
        {
            this.cardOnBattleField.Add(card);
        }
    }
}
