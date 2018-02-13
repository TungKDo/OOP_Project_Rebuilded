using Hearthstone.Card;
using Hearthstone.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Tests.Card.CreatureTests
{
    [TestClass]
    public class Attack_Should
    {
        [TestMethod]
        public void WhenCalled_ShoulDecreasePointsOfTarget()
        {
            var target = new Creature("target", 1, 1, 1, Enums.CreatureType.Beast);
            var creature = new Creature("mm", 1, 1, 1, Enums.CreatureType.Beast);

            creature.Attack(target);

            Assert.IsTrue(target.HealthPoints == 0);
        }
    }
}
