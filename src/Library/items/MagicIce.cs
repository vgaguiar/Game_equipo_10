namespace RoleplayGame.Items
{
    /// <summary>
    /// Magia. Permite atacar y defender.
    /// </summary>
    public class MagicIce : IAttackItem, IDefenseItem
    {
        private Magic magic = new Magic();
        private Ice ice = new Ice();

        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return ice.AttackPower+magic.AttackPower;
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
                return ice.DefensePower+magic.DefensePower;
            }
        }

        public override string ToString()
        {
            return "Magic Ice";
        }
    }
}