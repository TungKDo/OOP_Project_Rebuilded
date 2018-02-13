using Hearthstone.Card;
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

    class PlayGame : IPlayGame
    {
        private IPlayer player1;
        private IPlayer player2;
        private IDeckCollection deckCollection;
        private readonly Constants constants;

        public PlayGame(IDeckCollection deckCollection, Constants constants)
        {
            this.deckCollection = deckCollection;
            this.constants = constants;
        }

        public void PreGameSelection()
        {
            Console.WriteLine(constants.AskPlayerToSelectADeck, 1);
            deckCollection.PrintNameOfAllDecks();
            player1 = new Player(deckCollection.MyDeck[Console.ReadLine()]);
            Console.WriteLine(constants.AskPlayerToSelectADeck, 1);
            player2 = new Player(deckCollection.MyDeck[Console.ReadLine()]);

            player1.PlayerDeck.Shuffle();
            player2.PlayerDeck.Shuffle();
            for (int i = 0; i < 3; i++)
            {
                player1.DrawACard();
                player2.DrawACard();
            }

            string playerTurn = "P1";
            while (true)
            {
                if (playerTurn == "P1")
                {
                    Console.WriteLine("Player 1 Turn");
                    StartOfTurn(player1);
                    Console.WriteLine("===========================");
                    PlayTurn(player1, player2);
                    playerTurn = "P2";
                    if (player2.IsDead)
                    {
                        Console.WriteLine("Player 1 Won the game");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Player 2 Turn");
                    StartOfTurn(player2);
                    Console.WriteLine("===========================");
                    PlayTurn(player2, player1);
                    playerTurn = "P1";
                    if (player1.IsDead)
                    {
                        Console.WriteLine("Player 2 won the game!");
                        break;
                    }
                }
            }
            Environment.Exit(0);
        }
        private void StartOfTurn(IPlayer player)
        {
            if (player.MaxManaCrystals < 10)
            {
                player.MaxManaCrystals += 1;
            }
            player.ManaCrystals = player.MaxManaCrystals;
        }

        private void PlayTurn(IPlayer player, IPlayer opponent)
        {
            Console.WriteLine(constants.StartOfTurnOptions);

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "8")
                {
                    break;
                }
                switch (input)
                {
                    case "1":
                        Console.WriteLine(constants.AskToEnterCreatureName);
                        player.PrintCreaturesInHand();
                        ICreature creature = player.SelectACreature(Console.ReadLine());
                        if (creature.ManaCost > player.ManaCrystals)
                        {
                            Console.WriteLine(constants.NotEnoughManaCrystal);
                            break;
                        }
                        player.PlayCreature(creature);
                        break;

                    case "2":
                        Console.WriteLine(constants.AskToEnterSpellName);
                        player.PrintSpellsInHand();
                        ISpell spell = player.SelectASpell(Console.ReadLine());
                        if (spell.ManaCost > player.ManaCrystals)
                        {
                            Console.WriteLine(constants.NotEnoughManaCrystal);
                            break;
                        }
                        player.ManaCrystals -= spell.ManaCost;
                        player.PlayerHand.Remove(spell);
                        Console.WriteLine(constants.MenuWhenCastingSpell);
                        switch (Console.ReadLine())
                        {
                            case "1":
                                spell.CastSpell(opponent);
                                break;

                            case "2":
                                CastSpellOnOpponentsCreature(player, opponent, spell);
                                break;
                        }
                        break;

                    case "3":
                        if (opponent.BattleField.Count == 0)
                        {
                            Console.WriteLine(constants.EnemyDoesntHaveACreature);
                            PlayTurn(player, opponent);
                        }
                        else
                        {
                            Console.WriteLine(constants.AskToEnterCreatureName);
                            player.PrintCreaturesOnBattleField();
                            string attackingCreature = Console.ReadLine().ToLower();
                            ICreature myCreature = (ICreature)player.BattleField.FirstOrDefault(x => x.Name.ToLower() == attackingCreature);

                            Console.WriteLine(constants.EnterCreatureNameToBeAttacked);
                            opponent.PrintCreaturesOnBattleField();
                            string defendingCreature = Console.ReadLine().ToLower();
                            ICreature oppoCreature = (ICreature)opponent.BattleField.FirstOrDefault(x => x.Name.ToLower() == defendingCreature);
                            myCreature.Attack(oppoCreature);
                            if (oppoCreature.IsDead)
                            {
                                opponent.BattleField.Remove(oppoCreature);
                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine(constants.EnterCreatureName);
                        player.PrintCreaturesOnBattleField();
                        ICreature myCreature2 = (ICreature)player.BattleField.FirstOrDefault(x => x.Name.ToLower() == Console.ReadLine().ToLower());
                        myCreature2.Attack(opponent);
                        break;                        
                }
            }
            
        }
        
        private void CastSpellOnOpponentsCreature(IPlayer player, IPlayer opponent, ISpell spell)
        {
            if (opponent.BattleField.Count > 0)
            {
                Console.WriteLine(constants.EnterCreatureName);
                Console.WriteLine(string.Join("\n", opponent.BattleField));
                IDamageable target = opponent.SelectACreature(Console.ReadLine());
                spell.CastSpell(target);
                if (target.HealthPoints < 1)
                {
                    opponent.BattleField.Remove((ICreature)target);
                }
            }
            else
            {
                Console.WriteLine(constants.EnemyDoesntHaveACreature);
                PlayTurn(player, opponent);
            }
        }
    }
}
