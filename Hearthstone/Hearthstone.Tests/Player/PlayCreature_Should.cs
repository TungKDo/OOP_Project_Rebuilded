using System;
using Hearthstone.Collections;
using Hearthstone.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Hearthstone;

namespace Hearthstone.Tests
{
    [TestClass]
    public class PlayCreature_Should
    {
        [TestMethod]
        public void RemoveACardFromHand_WhenParamIsCorrect()
        {
            var deckStub = new Mock<IDeck>();
            var creatureStub = new Mock<ICreature>();

            var player = new Player(deckStub.Object);

            player.PlayerHand.Add(creatureStub.Object);

            player.PlayCreature(creatureStub.Object);

            Assert.AreEqual(player.BattleField.Count, 1);

        }
    }
}
