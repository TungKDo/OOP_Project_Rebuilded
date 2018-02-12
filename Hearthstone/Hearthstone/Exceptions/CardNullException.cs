using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Exceptions
{
    public class CardNullException : Exception
    {
        public CardNullException()
        {
        }

        public CardNullException(string message)
            : base(message)
        {
        }

        public CardNullException(string message, Exception inner)
        {
        }
    }
}
