﻿using Hearthstone.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Card
{
    public class Spell : Card, ISpell, ICard
    {
        private int damage;

        public Spell(string name, int manaCost, int damage) : base(name, manaCost)
        {
            base.Name = name;
            base.ManaCost = manaCost;
            this.Damage = damage;
        }

        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                this.damage = value;
            }
        }

        public void CastSpell(IDamageable target)
        {
            target.HealthPoints -= this.Damage;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendFormat("Name: {0}, Mana cost: {1}, Damage: {2}", this.Name, this.ManaCost, this.damage);

            return info.ToString();
        }
    }
}
