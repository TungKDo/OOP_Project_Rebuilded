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

        public Player(Deck playerDeck)
        {
            ManaCrystals = 0; //ok
            MaxManaCrystals = 0;
            this.PlayerDeck = playerDeck;
            PlayerHand = new List<ICard>();
            BattleField = new List<ICreature>();
            HealthPoints = 15;
        }
        public int ManaCrystals { get ; set ; }

        public int MaxManaCrystals {
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
        public int HealthPoints { get; set; }

        public void AttackWithCreature(ICreature attacking IPlayer opponent)
        {
            
            ICreature 
        }

        public ICreature SelectACreature(string creatureName)
        {
            creatureName = creatureName.ToLower();
            ICreature myCreature = (ICreature)this.BattleField.FirstOrDefault(x => x.Name.ToLower() == creatureName);
            return myCreature;
        }

        public void DrawACard()
        {
            if(PlayerDeck.Cards.Count > 0)
            {
                ICard cardToBeDraw = PlayerDeck.Cards[PlayerDeck.Cards.Count - 1];
                this.PlayerHand.Add(cardToBeDraw);
                this.PlayerDeck.Remove(cardToBeDraw);
            }
        }

        public bool IsDead()
        {
            throw new NotImplementedException();
        }

        public void PlayCreature()
        {
            throw new NotImplementedException();
        }

        public void PlaySpell(IPlayer opponent)
        {
            throw new NotImplementedException();
        }
    }
}
