using Hearthstone.Collections;
using Hearthstone.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace Hearthstone.Tests.Collections.DeckTests
{
    [TestClass]
    public class Shuffle_Should
    {
        [TestMethod]
        public void WhenCalled_ShouldCangeTheSequenceOfElements()
        {
            var card1 = new Mock<ICard>();
            var card2 = new Mock<ICard>();
            var card3 = new Mock<ICard>();

            List<ICard> listBeforeShuffle = new List<ICard> { card1.Object, card2.Object, card3.Object };

            var deck = new Mock<Deck>();

            deck.Object.Add(card1.Object);
            deck.Object.Add(card2.Object);
            deck.Object.Add(card3.Object);

            deck.Object.Shuffle();

            Assert.IsFalse(listBeforeShuffle.SequenceEqual(deck.Object.Cards));
        }
    }
}
