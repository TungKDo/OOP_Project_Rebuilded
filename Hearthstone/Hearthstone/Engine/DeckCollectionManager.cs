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
        private readonly IDeckCollection deckCollection;
        private readonly ICardFactory cardFactory;
        private readonly Constants contants;

        public DeckCollectionManager(IDeckCollection deckCollection, ICardFactory cardFactory, Constants contants)
        {
            this.deckCollection = deckCollection;
            this.cardFactory = cardFactory;
            this.contants = contants;
        }

        public void ManageDeckCollection()
        {
            Console.WriteLine(contants.DeckCollectionMenu);
            bool exit = true;
            string input = Console.ReadLine();
            while (exit)
            {                
                switch (input)
                {
                    case "1":
                        Console.WriteLine(contants.AskToEnterDeckName);
                        string deckName = Console.ReadLine().ToLower();
                        if (!string.IsNullOrEmpty(deckName))
                        {
                            deckCollection.CreateDeck(deckName);
                        }
                        ManageDeckCollection();
                        break;


                    case "2":
                        Console.WriteLine(contants.AskToEnterDeckName);
                        deckName = Console.ReadLine();
                        
                        deckCollection.RemoveDeck(deckName);

                        ManageDeckCollection();
                        break;

                    case "3":
                        AddMultipleCardsToDeck();
                        ManageDeckCollection();
                        break;
                    case "4":
                        RemoveMultipleCardsFromDeck();
                        ManageDeckCollection();
                        break;
                    case "5":
                        Console.WriteLine(contants.AskToEnterDeckName);
                        deckCollection.PrintNameOfAllDecks();
                        deckName = Console.ReadLine();
                        deckCollection.MyDeck[deckName].ListAllCards();
                        break;
                    case "6":
                        exit = false;
                        break;
                }
            }
        }

        private void RemoveMultipleCardsFromDeck()
        {
            Console.WriteLine(contants.AskToEnterDeckName);
            deckCollection.PrintNameOfAllDecks();
            string deckName = Console.ReadLine();

            Console.WriteLine("Please enter the name of the cards that you want to remove:");
            Console.WriteLine("When done, please type exit ");
            while (true)
            {
                string cardToBeRemoved = Console.ReadLine();
                if (cardToBeRemoved == "exit")
                {
                    break;
                }
                ICard card = deckCollection.MyDeck[deckName].Cards.FirstOrDefault(x => x.Name.ToLower() == cardToBeRemoved);
                if (card == null)
                    //Guard againts Null
                    deckCollection.MyDeck[deckName].Remove(card);
            }
        }

        private void AddMultipleCardsToDeck()
        {
            Console.WriteLine(contants.AskToEnterDeckName);
            deckCollection.PrintNameOfAllDecks();
            string deckName = Console.ReadLine();

            Console.WriteLine("Please enter the name of the cards that you want to add:");
            Console.WriteLine("When done, please type exit ");

            while (true)
            {
                string cardToBeAdded = Console.ReadLine();

                if (cardToBeAdded == "exit")
                {
                    break;
                }
                foreach (ICard card in deckCollection.MyDeck[deckName].Cards)
                {
                    if (card.Name.ToLower() == cardToBeAdded)
                    {
                        Console.WriteLine("You already have this card in this deck.");
                        ManageDeckCollection();
                    }
                }
                deckCollection.MyDeck[deckName].Add(cardFactory.CreateCard(cardToBeAdded));
            }
        }
    }
}
