using Hearthstone.Engine.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Engine
{
    public class MainMenu : IMainMenu
    {
        private readonly IDeckCollectionManager deckCollectionManager;
        private readonly IPlayGame playGame;
        private readonly Constants contants;

        public MainMenu(IDeckCollectionManager deckCollectionManager, IPlayGame playGame, Constants constants)
        {
            this.deckCollectionManager = deckCollectionManager;
            this.playGame = playGame;
            this.contants = constants;
        }
        public void Run()
        {
            Console.WriteLine(contants.MainMenuOptions);

            string input = Console.ReadLine();

            bool isInValidInput = false;

            while (!isInValidInput)
            {
                switch (input)
                {
                    case "1":
                        {
                            playGame.PreGameSelection();
                            break;
                        }
                    case "2":
                        {
                            deckCollectionManager.ManageDeckCollection();
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine(contants.ShowCredits);
                            break;
                        }

                    case "4":
                        {
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Run();
                            break;
                        }
                }
            }
        }



    }
}
