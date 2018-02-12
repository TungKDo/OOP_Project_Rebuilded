using Hearthstone.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Card
{
    public abstract class Card : ICard
    {
        private string name;
        private int manaCost;

        public Card(string name, int manaCost)
        {
            this.Name = name;
            this.ManaCost = manaCost;
        }

        public string Name
        {
            get { return this.name; }
            protected set { this.name = value; }
        }
        
        public int ManaCost
        {
            get { return this.manaCost;}
            protected set { this.manaCost = value; }
        }
    }
}
