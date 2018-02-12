using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Engine
{
    public class Constants
    {
        public virtual string MainMenuOptions => "\n1. New Game\n2. Deck Collection\n3. Credits\n4. Exit";
        public virtual string DeckCollectionMenu => "\n1. Create Deck\n2. Delete Deck\n3. Add cards to an existing Deck\n4. Remove cards to an existing Deck\n5. List all cards in a deck\n6. Back";
        public virtual string AskToEnterDeckName => "Please type in the deck name";
        public virtual string AskPlayerToSelectADeck => "Player {0} please choose your deck:";
        public virtual string StartOfTurnOptions => "1. Play a Monster\n2. Cast a Spell\n3. Attack opponent's creature with your creature\n4. Attack the opponent's hero with your creature\n8. End Turn";
        public virtual string AskToEnterCreatureName => "Please enter the name of the creature you would like to play:";
        public virtual string NotEnoughManaCrystal => "Not Enough Mana Crystals";
        public virtual string AskToEnterSpellName => "Please enter the name of the creature you would like to play:";
        public virtual string MenuWhenCastingSpell => "\n1.Opponent's hero\n2.Opponent's creature";
        public virtual string EnterCreatureName => "Please enter the name of the creature you would like to target:";
        public virtual string EnemyDoesntHaveACreature => "Opponent doesn't have any creatures on the battlefield";
        public virtual string EnterCreatureNameToBeAttacked =>"Please enter the name of the creature you would like to attack:";
        public virtual string ShowCredits => ($"===========================\n"+ $"This game was created by:\nAlexandra Petrova\nBorislav Borisov\nTung Do\n" + $"===========================\n\n");
    }
}
