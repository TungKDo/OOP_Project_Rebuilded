using Hearthstone.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Card
{
    class Spell : ISpell
    {
        public int Damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ManaCost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void CastSpell(IDamageable target)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
