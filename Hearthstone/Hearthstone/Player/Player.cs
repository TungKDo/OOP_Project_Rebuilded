﻿using Hearthstone.Collections;
using Hearthstone.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Player
{
    class Player : IPlayer
    {
        private int maxManaCrystals;

        public Player(Deck playerDeck)
        {
            ManaCrystal = 0; //ok
            MaxManaCrystal = 0;
            this.PlayerDeck = playerDeck;
            PlayerHand = new List<ICard>();
            BattleField = new List<ICreature>();
            HealthPoints = 15;
        }
        public int ManaCrystal { get ; set ; }

        public int MaxManaCrystal {
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

        public void DrawCard()
        {
            throw new NotImplementedException();
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