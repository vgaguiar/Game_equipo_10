using System.Collections.Generic;

namespace RoleplayGame.Items
{
    /// <summary>
    /// Magia. Permite atacar y defender.
    /// </summary>
    public class InfiniteGauntlet : IAttackItem,IAddStone
    {
        private List<Stone> gemas = new List<Stone>();
        public int AttackPower
        {
            get
            {
                if (gemas is null)
                {
                    return 80;
                }
                else
                {
                    int suma = 0;
                    foreach(Stone gema in gemas)
                    {
                        suma = suma + gema.Power;
                    }
                    return suma;
                }
            }
        }
        public void AddStone()
        {
            Stone newStone = new Stone();
            gemas.Add(newStone);
        }

        public override string ToString()
        {
            return "Infinite Gauntlet";
        }
    }
}