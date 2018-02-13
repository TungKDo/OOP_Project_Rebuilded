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
        public void IsCalledOnce_ParamIsValid()
        {
            int possitiveAttack = 3;
            int manaCost = 2;
            string validName = "attacker";
            int healthpoints = 5;
            var type = CreatureType.Neutral;

            int targetsHearthPoints = 4;

            var attacker = new Creature(validName, manaCost, possitiveAttack, healthpoints, type);
            var target = new Mock<IDamageable>();

            target.SetupGet(x => x.HealthPoints).Returns(targetsHearthPoints);
            
            attacker.Attack(target.Object);
            //target.Verify(x => x.HealthPoints != targetsHearthPoints);
            target.Verify(x => x.HealthPoints, Times.Once);
            


        }
    }
}
