using Hearthstone.Contracts;
using System.Collections.Generic;

namespace Hearthstone.Collections
{
    public interface IDeck
    {
        IList<ICard> Cards { get; set; }
        void Add(ICard card);
        void Remove(ICard card);
        void ListAllCards();
        void Shuffle();
    }
}