using Hearthstone.Collections;
using Hearthstone.Contracts;
using Hearthstone.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Tests.Collections.DeckTests
{
    [TestClass]
    public class Add_Should
    {
        [TestMethod]
        public void ThrowsCardNullException_WhenPassedNullArgument()
        {
            var deck = new Deck();
            
            Assert.ThrowsException<CardNullException>(() => deck.Add(null));
        }
    }
}
