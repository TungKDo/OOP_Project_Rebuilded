using Hearthstone.Collections;
using Hearthstone.Contracts;
using Hearthstone.Engine.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Engine
{
    public class DeckCollectionManager : IDeckCollectionManager
    {
        private readonly IMainMenu mainMenu;
        private readonly IDeckCollection deckCollection;
        private readonly ICardFactory cardFactory;

        public DeckCollectionManager(IMainMenu mainMenu, IDeckCollection deckCollection,ICardFactory cardFactory)
        {
            this.mainMenu = mainMenu;
            this.deckCollection = deckCollection;
            this.cardFactory = cardFactory;
        }

        public void ManageDeckCollection()
        {
            Constants.DeckCollectionMenu;

            string input = Console.ReadLine();
            while (true)
            {
                switch (input)
                {
                    case "1":
                        Constants.AskToEnterDeckName;
                        string deckName = Console.ReadLine().ToLower();
                        if (!string.IsNullOrEmpty(deckName))
                        {
                            deckCollection.CreateDeck(deckName);
                        }
                        ManageDeckCollection();
                        break;


                    case "2":
                        Constants.AskToEnterDeckName;
                        deckName = Console.ReadLine();

                        if (!string.IsNullOrEmpty(deckName))
                        {
                            if (Check.IfDeckExists(deckCollection, deckName))
                            {
                                deckCollection.RemoveDeck(deckName);
                            }
                        }
                        ManageDeckCollection();
                        break;

                    case "3":
                        Constants.AskToEnterDeckName;
                        deckCollection.PrintNameOfAllDecks();
                        deckName = Console.ReadLine();

                        Console.WriteLine("Please enter the name of the cards that you want to add:");
                        Console.WriteLine("When done, please type exit ");

                        while (true)
                        {
                            string cardToBeAdded = Console.ReadLine();

                            if (cardToBeAdded == "exit")
                            {
                                break;
                            }
                            foreach (ICard card in deckCollection.MyDeck)
                            {
                                if (card.Name.ToLower() == cardToBeAdded)
                                {
                                    Console.WriteLine("You already have this card in this deck.");
                                    ManageDeckCollection();
                                }
                            }
                                deckCollection.MyDeck[deckName].Add(cardFactory.CreateCard(cardToBeAdded));
                        }

                        ManageDeckCollection();
                        break;
                }
            }
        }
    }
}
