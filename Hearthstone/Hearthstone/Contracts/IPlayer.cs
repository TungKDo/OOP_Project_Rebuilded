using Hearthstone.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Contracts
{
    interface IPlayer : IDamageable
    {
        int ManaCrystal { get; set; }
        int MaxManaCrystal { get; set; }
        Deck PlayerDeck { get; set; }
        List<ICard> PlayerHand { get; set; }
        List<ICreature> BattleField { get; set; }
        void DrawCard();
        void PlayCreature();
        void PlaySpell(IDamageable opponent);
        void AttackWithCreature(ICreature attackingCreature, IDamageable opponent);

    }
}
