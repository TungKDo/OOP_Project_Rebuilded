using Hearthstone.Contracts;
using Hearthstone.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Card
{
    class Creature : Card, ICreature, ICard
    {
        private int attackPoints;
        private int healtPoints;
        private readonly CreatureType creatureType;
       
        public Creature(string name, int manaCost, int attackPoints, int healthPoints, CreatureType creatureType) 
            : base(name, manaCost)
        {
            this.AttackPoints = attackPoints;
            this.HealthPoints = healthPoints;
            this.creatureType = creatureType;
        }

        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            protected set
            {
                this.attackPoints = value;
            }
        }

        public int HealthPoints
        {
            get
            {
                return this.healtPoints;
            }
            set
            {
                this.healtPoints = value;
            }
        }

        public CreatureType CreatureType
        {
            get
            {
                return this.creatureType;
            }
        }

        public bool IsDead { get; set; }

        public void Attack(IDamageable target)
        {
            
            target.HealthPoints -= this.AttackPoints;
        }

        
        public override string ToString()
        {
            return string.Format("Name: {0}, Mana cost: {1}, Attack points: {2}, Health points: {3}, Creature type:{4}",
                base.Name, base.ManaCost, this.AttackPoints, this.HealthPoints, this.CreatureType);
        }
    }
}
