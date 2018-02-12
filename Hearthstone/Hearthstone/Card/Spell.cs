using Hearthstone.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Card
{
    class Spell : Card, ISpell
    {
        private int damage;

        public Spell(string name, int manaCost, int damage) : base(name, manaCost)
        {
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
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Mana cost: {1}, Damage: {2}", this.Name, this.ManaCost, this.damage);
        }
    }
}
