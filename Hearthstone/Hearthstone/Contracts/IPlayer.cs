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
        
        int ManaCrystals { get; set; }
        int MaxManaCrystals { get; set; }
        Deck PlayerDeck { get; set; }
        List<ICard> PlayerHand { get; set; }
        List<ICreature> BattleField { get; set; }

        void DrawACard();
        void PlaySpell(IDamageable opponent);
        void PlayCreature(ICreature card);

        ICreature SelectACreature(string creatureName);
        ISpell SelectASpell(string spellName);

        void PrintCreaturesInHand();
        void PrintSpellsInHand();
        void PrintCreaturesOnBattleField();

    }
}
