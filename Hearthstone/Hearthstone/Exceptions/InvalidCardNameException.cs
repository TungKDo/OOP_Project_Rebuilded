using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Exceptions
{
    public class InvalidCardNameException : Exception
    {
        public InvalidCardNameException()
        {
        }

        public InvalidCardNameException(string message)
            : base(message)
        {
        }

        public InvalidCardNameException(string message, Exception inner)
        {
        }
    }
}
