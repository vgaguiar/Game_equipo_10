namespace RoleplayGame.Items
{
    /// <summary>
    /// Magia. Permite atacar y defender.
    /// </summary>
    public class Ice : IAttackItem, IDefenseItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 40;
            }
        }

        /// <summary>
        /// El poder de defensa
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 60;
            }
        }

        public override string ToString()
        {
            return "Ice";
        }
    }
}