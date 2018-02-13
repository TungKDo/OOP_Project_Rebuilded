using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Contracts
{
    public interface IDamageable
    {
        int HealthPoints { get; set; }
        bool IsDead { get; set; }
    }
}
