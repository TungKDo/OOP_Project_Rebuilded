using Hearthstone.Card;
using Hearthstone.Contracts;
using Hearthstone.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
namespace Hearthstone.Tests.Factory.CardFactoryTests
{
    [TestClass]
    public class CreateCard_Should
    {
        [TestMethod]
        public void WhenCalledWithValidCardName_ReturnsValidObject()
        {
            var validName = "Alexstrasza";
            var creature = new Creature("Alexstrasza", 9, 8, 8, CreatureType.Neutral);
            var factory = new Mock<ICardFactory>();
            factory.Setup(m => m.CreateCard(validName)).Returns(creature);

            Assert.AreSame(creature, factory.Object.CreateCard(validName));
        }
    }
}