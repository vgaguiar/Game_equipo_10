using RoleplayGame.Characters;
using RoleplayGame.Items;
using RoleplayGame.Encounters;
using System.Collections.Generic;
using System;

namespace RoleplayGame.Scenarios
{
    public class TestScenario : IScenario
    {
        protected List<Character> characters = new List<Character>();

        void Setup()
        {
            Character MagicGladiador = new Gladiador("MagicGladiador");
            Character KingTroll = new Troll("KingTroll");
            Character QueenElf = new Elf("QueenElf");
            Character MagicWizard = new Wizard("MagicWizard");
            IItem PinkyBow = new BowAndArrow();
            IItem IcedCup = new Ice();
            QueenElf.AddItem(IcedCup);
            QueenElf.AddItem(PinkyBow);
            IItem Blade = new LightSaber();
            IItem Axe = new FireAx();
            KingTroll.AddItem(Blade);
            KingTroll.AddItem(Axe);
            IItem Saber = new LightSaber();
            IItem BlueRobe = new Robes();
            MagicWizard.AddItem(Saber);
            MagicWizard.AddItem(Blade);
            IItem ChainArmor = new CompleteArmor();
            InfiniteGauntlet Gauntlet = new InfiniteGauntlet();
            Gauntlet.AddStone();
            MagicGladiador.AddItem(ChainArmor);
            MagicGladiador.AddItem(Gauntlet);
            characters.Add(MagicGladiador);
            characters.Add(KingTroll);
            characters.Add(QueenElf);
            characters.Add(MagicWizard);
            
            
        }

        /// <summary>
        /// Ejecución del escenario.
        /// </summary>
        void Run()
        {
            Encounter battleOne = new AttackEncounter(characters[0], characters[1]);
            Encounter battleTwo = new AttackEncounter(characters[2], characters[3]);
            RemoveDeadChar();
            Encounter finalBattle = new AttackEncounter(characters[0], characters[1]);
            RemoveDeadChar();
            Console.WriteLine($"The Winner is : {characters[0].Name}");


        }
        private void RemoveDeadChar() 
        {
             foreach(Character character in characters)
            {
                if(character.IsDead)
                {
                    characters.Remove(character);
                }
            }
        }
    }
}