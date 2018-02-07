using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Contracts
{
    interface ISpell: ICard
    {
        int Damage { get; set; }
        void CastSpell(IDamageable target);
    }
}
