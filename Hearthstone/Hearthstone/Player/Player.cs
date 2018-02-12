using Hearthstone.Collections;
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
        private int healthPoints;
        private bool isDead;

        public Player(Deck playerDeck)
        {
            ManaCrystal = 0;
            MaxManaCrystal = 0;
            this.PlayerDeck = playerDeck;
            PlayerHand = new List<ICard>();
            BattleField = new List<ICreature>();
            HealthPoints = 15;
            IsDead = false;
        }
        public int ManaCrystal { get; set; }

        public int MaxManaCrystal
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
                if(value <0)
                {
                    this.IsDead = true;
                }
            }
        }

        public bool IsDead
        {
            get
            {
                return this.isDead;
            }
            set
            {
                this.isDead = value;
            }
        }

        public void AttackWithCreature(ICreature attackingCreature, IDamageable opponent)
        {
            attackingCreature.Attack(opponent);
        }

        public ICreature SelectACreature(string creatureName)
        {
            creatureName = creatureName.ToLower();
            ICreature myCreature = this.BattleField.FirstOrDefault(x => x.Name.ToLower() == creatureName);
            return myCreature;
        }

        public ISpell SelectASpell(string spellName)
        {
            spellName = spellName.ToLower();
            ISpell spell = (ISpell)this.PlayerHand.FirstOrDefault(x => x.Name.ToLower() == spellName);
            return spell;
        }
        public void DrawCard()
        {
            ICard cardToBeDraw = PlayerDeck.Cards[0];
            this.PlayerHand.Add(cardToBeDraw);
            this.PlayerDeck.Cards.Remove(cardToBeDraw);
        }


        public void PlayCreature(ICreature creature)
        {
            PlayerHand.Remove(creature);
            BattleField.Add(creature);
        }

        public void PlaySpell(ISpell spell,IDamageable opponent)
        {
            opponent.HealthPoints = spell.Damage;
            
        }

    }
}
