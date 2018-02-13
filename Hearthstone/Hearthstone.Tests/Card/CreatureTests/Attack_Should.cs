using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hearthstone.Enums;
using Moq;
using Hearthstone.Contracts;
using Hearthstone.Card;

namespace Hearthstone.Tests.Card.CreatureTests
{
    [TestClass]
    public class Attack_Should
    {
        [TestMethod]
        public void DamageTarget_AttackerDamageIsPossitive()
        {
            int possitiveAttack = 3;
            int manaCost = 2;
            string validName = "attacker";
            int healthpoints = 5;
            var type = CreatureType.Neutral;

            var attacker = new Creature(validName, manaCost, possitiveAttack, healthpoints, type);
            var target = new Mock<IDamageable>();

            target.SetupGet(x => x.HealthPoints).Returns(5);
            attacker.Attack(target.Object);
            target.Verify(x => x.HealthPoints != 5);


        }
    }
}
