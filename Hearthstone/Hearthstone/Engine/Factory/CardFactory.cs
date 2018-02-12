using Hearthstone.Card;
using Hearthstone.Contracts;
using Hearthstone.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearthstone.Engine.Factory
{
    public class CardFactory : ICardFactory
    {
        public ICard CreateCard(string cardToBeAdded)
        {
            cardToBeAdded = cardToBeAdded.ToLower();
            switch (cardToBeAdded)
            {
                case "aldorpeacekeeper":
                    {
                        return new Creature("AldorPeacekeeper", 3, 3, 3, CreatureType.Neutral);
                    }
                case "alexstrasza":
                    {
                        return new Creature("Alexstrasza", 9, 8, 8, CreatureType.Neutral);
                    }
                case "ancientbrewmaster":
                    {
                        return new Creature("AncientBrewmaster", 4, 5, 4, CreatureType.Neutral);
                    }
                case "ancientmage":
                    {
                        return new Creature("AncientMage", 4, 2, 5, CreatureType.Neutral);
                    }
                case "archmageantonidas":
                    {
                        return new Creature("ArchmageAntonidas", 7, 5, 7, CreatureType.Neutral);
                    }
                case "auchenaisoulpriest":
                    {
                        return new Creature("AuchenaiSoulpriest", 4, 3, 5, CreatureType.Neutral);
                    }
                case "cenarius":
                    {
                        return new Creature("Cenarius", 9, 5, 8, CreatureType.Neutral);
                    }
                case "chillwindyeti":
                    {
                        return new Creature("ChillWindYeti", 4, 4, 5, CreatureType.Beast);
                    }
                case "deathwing":
                    {
                        return new Creature("Deathwing", 10, 12, 10, CreatureType.Neutral);
                    }
                case "doomguard":
                    {
                        return new Creature("Doomguard", 5, 5, 7, CreatureType.Neutral);
                    }
                case "druidoftheclaw":
                    {
                        return new Creature("DruidOfTheClaw", 5, 4, 4, CreatureType.Neutral);
                    }
                case "emperorcobra":
                    {
                        return new Creature("EmperorCobra", 3, 3, 3, CreatureType.Beast);
                    }
                case "manawyrm":
                    {
                        return new Creature("ManaWyrm", 1, 1, 3, CreatureType.Neutral);
                    }
                case "ogre":
                    {
                        return new Creature("Ogre", 6, 6, 7, CreatureType.Neutral);
                    }
                case "swampooze":
                    {
                        return new Creature("SwampOoze", 2, 3, 2, CreatureType.Neutral);
                    }
                case "tiger":
                    {
                        return new Creature("Tiger", 5, 5, 5, CreatureType.Beast);
                    }
                case "waterelemental":
                    {
                        return new Creature("WaterElemental", 6, 4, 3, CreatureType.Elemental);
                    }
                case "fireball":
                    {
                        return new Spell("FireBall", 4, 5);
                    }
                case "fireblast":
                    {
                        return new Spell("FireBlast", 7, 9);
                    }
                case "frostbolt":
                    {
                        return new Spell("FrostBolt", 2, 3);
                    }
                case "holysmite":
                    {
                        return new Spell("HolySmite", 1, 2);
                    }
                case "lightningbolt":
                    {
                        return new Spell("LightningBolt", 6, 7);
                    }
                case "meteorShower":
                    {
                        return new Spell("MeteorShower", 5, 6);
                    }
                case "moonfire":
                    {
                        return new Spell("MoonFire", 0, 1);
                    }
                case "shawdowbolt":
                    {
                        return new Spell("ShadowBolt", 3, 4);
                    }
                default:
                    {
                        Console.WriteLine("This Card doesn't exist");
                        //DeckCollectionManagement.ManageDeckCollection();
                        return new Spell("ShadowBolt", 3, 4);
                    }
            }
        }
    }
}
