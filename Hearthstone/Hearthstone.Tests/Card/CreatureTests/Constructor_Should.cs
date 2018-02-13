using Hearthstone.Card;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Tests.Card.CreatureTests
{
    [TestClass]
    public class Constructor_Should
    {
        [TestMethod]
        public void ShouldThrowArgumentNullException_WhenNameIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Creature(null, 1, 1, 1, Enums.CreatureType.Beast));
        }

        [TestMethod]
        public void ShouldThrowArgumentException_WhentManaCostIsNegativeNumber()
        {
            Assert.ThrowsException<ArgumentException>(() => new Creature("creature", -1, 1, 1, Enums.CreatureType.Beast));
        }
    }
}
