namespace RoleplayGame.Items
{
    /// <summary>
    /// Sable laser. Permite atacar y defender.
    /// </summary>
    public class LightSaber : IAttackItem, IDefenseItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 90;
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
                return 20;
            }
        }

        public override string ToString()
        {
            return "Light saber";
        }
    }
}
