using Hearthstone.Card;
using Hearthstone.Collections;
using Hearthstone.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone
{
    class Player : IPlayer
    {
        private int maxManaCrystals;
        private int healthPoints;

        public Player(Deck playerDeck)
        {
            ManaCrystals = 0; //ok
            MaxManaCrystals = 0;
            this.PlayerDeck = playerDeck;
            PlayerHand = new List<ICard>();
            BattleField = new List<ICreature>();
            HealthPoints = 15;
        }
        public int ManaCrystals { get; set; }

        public int MaxManaCrystals
        {
            get
            {
                return maxManaCrystals;
            }
            set
            {
                this.maxManaCrystals = value;
            }
        }
        public Deck PlayerDeck { get; set; }


        public List<ICard> PlayerHand { get; set; }
        public List<ICreature> BattleField { get; set; }
        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                this.healthPoints = value;
                if (value < 0)
                {
                    IsDead = true;
                }
            }
        }
        public bool IsDead { get; set; }


        public ICreature SelectACreature(string creatureName)
        {
            creatureName = creatureName.ToLower();
            ICreature myCreature = (ICreature)this.PlayerHand.FirstOrDefault(x => x.Name.ToLower() == creatureName);
            return myCreature;
        }

        public ISpell SelectASpell(string spellName)
        {
            spellName = spellName.ToLower();
            ISpell mySpell = (ISpell)this.PlayerHand.FirstOrDefault(x => x.Name.ToLower() == spellName);
            return mySpell;
        }


        public void DrawACard()
        {
            if (PlayerDeck.Cards.Count > 0)
            {
                ICard cardToBeDraw = PlayerDeck.Cards[PlayerDeck.Cards.Count - 1];
                this.PlayerHand.Add(cardToBeDraw);
                this.PlayerDeck.Remove(cardToBeDraw);
            }
        }

        public void PlayCreature(ICreature card)
        {
            PlayerHand.Remove(card);
            BattleField.Add(card);
            ManaCrystals -= (int)card.ManaCost;
        }

        public void PrintCreaturesInHand()
        {
            foreach (var card in PlayerHand)
            {
                if (card.GetType() == typeof(Creature))
                {
                    Console.WriteLine(card.ToString());
                }
            }
        }
        public void PrintSpellsInHand()
        {
            foreach (var card in PlayerHand)
            {
                if (card.GetType() == typeof(Spell))
                {
                    Console.WriteLine(card.ToString());
                }
            }
        }

        public void PrintCreaturesOnBattleField()
        {
            foreach (var card in BattleField)
            {
                Console.WriteLine(card.ToString());
            }
        }

        public void PlaySpell(IPlayer opponent)
        {
            throw new NotImplementedException();
        }

        public void PlaySpell(IDamageable opponent)
        {
            throw new NotImplementedException();
        }


    }
}
