using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Contracts
{
    interface ICreature: ICard, IDamageable
    {
        int AttackPoints { get; }
        void Attack(IDamageable target);
    }
}
